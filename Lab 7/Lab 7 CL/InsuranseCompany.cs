using Lab_6_CL.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InsuranseCompanyCL
{
    /// <summary>
    /// Страховая компания
    /// </summary>
    public class InsuranseCompany
    {
        /// <summary>
        /// Единственный экзепляр класса Страховая компания
        /// </summary>
        private static InsuranseCompany _instance;

        public static InsuranseCompany Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new InsuranseCompany();
                }
                return _instance;
            }
        }

        /// <summary>
        /// Приватный конструктор
        /// </summary>
        private InsuranseCompany()
        {

        }

        /// <summary>
        /// Словарь типов страхования
        /// 
        /// </summary>
        private static Dictionary<int, InsuranseType> _types { get; } = new Dictionary<int, InsuranseType>();

        /// <summary>
        /// Словарь филиалов
        /// </summary>
        private static Dictionary<int, InsuranseBranch> _branches { get; } = new Dictionary<int, InsuranseBranch>();

        /// <summary>
        /// Словарь страховых договоров
        /// </summary>
        private static List<InsuranseContract> _contracts { get; } = new List<InsuranseContract>();

        /// <summary>
        /// Коллекция типов договора
        /// </summary>
        public IEnumerable<InsuranseType> Types
        {
            get
            {
                return _types.Values.AsEnumerable();
            }
        }

        /// <summary>
        /// Коллекция филиалов
        /// </summary>
        public IEnumerable<InsuranseBranch> Branches
        {
            get
            {
                return _branches.Values.AsEnumerable();
            }
        }

        /// <summary>
        /// Коллекция страховых договоров
        /// </summary>
        public IEnumerable<InsuranseContract> Contracts
        {
            get
            {
                return _contracts;
            }
        }

        public event EventHandler TypeAdded;
        public event EventHandler TypeRemoved;
        public event EventHandler BranchAdded;
        public event EventHandler BranchRemoved;
        public event EventHandler ContractAdded;
        public event EventHandler ContractRemoved;

        /// <summary>
        /// Добавление типа страхования
        /// </summary>
        /// <param name="type"></param>
        public void AddType(InsuranseType type)
        {
            if (!type.IsValid)
            {
                throw new InvalidTypeException("Информация о типе договора заполнена некорректно");
            }
            try
            {
                _types.Add(type.Number, type);
                //Герерируем событие о том, что тип добавлен
                TypeAdded?.Invoke(type, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidTypeException("При добавлении типа договора произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Добавление филиала
        /// </summary>
        /// <param name="branch">Информация о филиале</param>
        public void AddBranch(InsuranseBranch branch)
        {
            if (!branch.IsValid)
            {
                throw new InvalidBranchException("Информация о филиале заполнена некорректно");
            }
            try
            {
                _branches.Add(branch.Number, branch);
                //Герерируем событие о том, что филиал добавлен
                BranchAdded?.Invoke(branch, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidBranchException("При добавлении филиала произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Добавление договора
        /// </summary>
        /// <param name="contract"></param>
        public void AddContract(InsuranseContract contract)
        {
            if (!contract.IsValid)
            {
                throw new InvalidContractException("Информация о договоре заполнена некорректно");
            }
            try
            {
                _contracts.Add(contract);
                //Герерируем событие о том, что информация о договоре добавлена
                ContractAdded?.Invoke(contract, EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidContractException("При добавлении договора произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Удалить тип страхования по его номеру
        /// </summary>
        /// <param name="typeKey">Идентификатор типа страхования</param>
        public void RemoveType(int typeKey)
        {
            _types.Remove(typeKey);
            //Генерируем событие о том, что тип страхования удалён
            TypeRemoved?.Invoke(typeKey, EventArgs.Empty);
            //Получаем список сведений о типе страхования
            var typesForContract = Contracts.Where(s => s.InsuranceType.Number == typeKey).ToList();
            for (int i = 0; i < typesForContract.Count; i++)
            {
                //Удаляем сведения о типе страхования
                RemoveContract(typesForContract[i]);
            }
        }

        /// <summary>
        /// Удалить филиал по идентификатору
        /// </summary>
        /// <param name="branchKey"></param>
        public void RemoveBranch(int branchKey)
        {
            _branches.Remove(branchKey);
            //Генерируем событие о том, что филиал удалён
            BranchRemoved?.Invoke(branchKey, EventArgs.Empty);
            //Получаем список сведений о филиалах
            var branchesForRoom = Contracts.Where(s => s.Branch.Number == branchKey).ToList();
            for (int i = 0; i < branchesForRoom.Count; i++)
            {
                //Удаляем сведения о филиалах
                RemoveContract(branchesForRoom[i]);
            }
        }
        /// <summary>
        /// Удалить договор
        /// </summary>
        /// <param name="contract">Информация о договоре</param>
        public void RemoveContract(InsuranseContract contract)
        {
            _contracts.Remove(contract);
            //Генерируем событие о том, что информация о договоре удалена
            ContractRemoved?.Invoke(contract, EventArgs.Empty);
        }

    }
}
