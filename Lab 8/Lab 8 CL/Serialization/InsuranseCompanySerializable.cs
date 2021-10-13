using InsuranseCompanyCL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab_7_CL.Serialization
{

    [Serializable]
    public class InsuranseCompanySerializable
    {

        /// <summary>
        /// Словарь типов страхования
        /// 
        /// </summary>
        public  List<InsuranseType> Types { get; } = new List<InsuranseType>();

        /// <summary>
        /// Словарь филиалов
        /// </summary>
        public  List<InsuranseBranch> Branches { get; } = new List<InsuranseBranch>();

        /// <summary>
        /// Словарь страховых договоров
        /// </summary>
        public  List<InsuranseContractSerializable> Contracts { get; } = new List<InsuranseContractSerializable>();

        public static void Save(string fileName, SerializeType serType)
        {
            var companySerializable = new InsuranseCompanySerializable();
            var company = InsuranseCompany.Instance;
            foreach (var branch in company.Branches)
            {
                
                companySerializable.Branches.Add(branch);
            }
            foreach (var type in company.Types)
            {
                companySerializable.Types.Add(type);
            }
            foreach (var contract in company.Contracts)
            {
                companySerializable.Contracts.Add(new InsuranseContractSerializable
                {
                    Number = contract.Number,
                    BranchNumber = contract.Branch.Number,
                    TypeNumber = contract.InsuranceType.Number,
                    DateOfConclusion = contract.DateOfConclusion,
                    Amount = contract.Amount,
                    TarifRate = contract.TarifRate
                });
            }
            switch (serType)
            {
                case SerializeType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(InsuranseCompanySerializable));
                    using (StreamWriter xmlStreamWriter = new StreamWriter(fileName))
                    {
                        xmlSerializer.Serialize(xmlStreamWriter, companySerializable);
                    }
                    break;
                case SerializeType.JSON:
                    using (StreamWriter jsonStreamWriter = File.CreateText(fileName))
                    {
                        JsonSerializer jsonSerializer = new JsonSerializer { Formatting = Formatting.Indented };
                        jsonSerializer.Serialize(jsonStreamWriter, companySerializable);
                    }
                    break;
                case SerializeType.Binary:
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream binaryFileStream = new FileStream(fileName, FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(binaryFileStream, companySerializable);
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(serType), serType, null);
            }
        }

        public static void Load(string fileName, SerializeType type)
        {
            InsuranseCompanySerializable companySerializable;
            switch (type)
            {
                case SerializeType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(InsuranseCompanySerializable));
                    StreamReader streamReader = new StreamReader(fileName);
                    companySerializable = (InsuranseCompanySerializable)xmlSerializer.Deserialize(streamReader);
                    break;
                case SerializeType.JSON:
                    StreamReader jsonStreamReader = File.OpenText(fileName);
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    companySerializable = (InsuranseCompanySerializable)jsonSerializer.Deserialize(jsonStreamReader, typeof(InsuranseCompanySerializable));
                    break;
                case SerializeType.Binary:
                    BinaryFormatter formatter = new BinaryFormatter();
                    FileStream binaryFileStream = new FileStream(fileName, FileMode.Open);
                    companySerializable = (InsuranseCompanySerializable)formatter.Deserialize(binaryFileStream);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
            var company = InsuranseCompany.Instance;
            var companyBranches = company.Branches.ToList();
            var companyTypes = company.Types.ToList();
            var companyContracts = company.Contracts.ToList();
            foreach (var companyBranch in companyBranches)
            {
                company.RemoveBranch(companyBranch.Number);
            }
            foreach (var companyType in companyTypes)
            {
                company.RemoveType(companyType.Number);
            }
            foreach (var companyContract in companyContracts)
            {
                company.RemoveContract(companyContract);
            }
            var branches = new Dictionary<int, InsuranseBranch>();
            var types = new Dictionary<int, InsuranseType>();
            int maxBranchNumber = 0;
            foreach (var branch in companySerializable.Branches)
            {
                if (branch.Number > maxBranchNumber) maxBranchNumber = branch.Number;
                branches.Add(branch.Number, branch);
                company.AddBranch(branch);
            }
            foreach (var insType in companySerializable.Types)
            {
                types.Add(insType.Number, insType);
                company.AddType(insType);
            }
            foreach (var contract in companySerializable.Contracts)
            {
                company.AddContract(new InsuranseContract
                {
                    Branch = branches[contract.BranchNumber],
                    InsuranceType = types[contract.TypeNumber],
                    DateOfConclusion = contract.DateOfConclusion,
                    Amount = contract.Amount,
                    TarifRate = contract.TarifRate
                });
            }
            InsuranseBranch.NewNumber = maxBranchNumber;
        }
    }
}
