using ClassLibraryRivers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiverClient
{
    public partial class NewRiverForm : Form
    {
        public NewRiverForm()
        {
            InitializeComponent();
        }

        private void NewRiverForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonNewRiver_Click(object sender1, EventArgs e)
        {
            try
            {


                // Буфер для входящих данных
                byte[] bytes = new byte[10240];

                // Соединяемся с удаленным устройством

                // Устанавливаем удаленную точку для сокета
                IPHostEntry ipHost = Dns.GetHostEntry("localhost");
                IPAddress ipAddr = ipHost.AddressList[0];
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);

                Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                // Соединяем сокет с удаленной точкой
                sender.Connect(ipEndPoint);
                RiverRequest request = null;

                request = new RiverRequest
                {
                    River = new River
                    {
                        Title = textBoxRiverName.Text,
                        Length = double.Parse(textBoxRiverLength.Text),
                        FoundationDate = DateTime.Parse(textBoxRiverFoundDate.Text),
                        TributaryCount = int.Parse(textBoxTribCount.Text)
                    },
                    Key = textBoxRiverKey.Text,
                    Type = RiverRequestType.Add
                };

                if (string.IsNullOrWhiteSpace(request.Key))
                {
                    throw new ApplicationException("Ключ не может быть пустым");
                }
                string jsonRequest = JsonConvert.SerializeObject(request);
                byte[] msg = Encoding.UTF8.GetBytes(jsonRequest);
                // Отправляем данные через сокет
                sender.Send(msg);

                int bytesRec = sender.Receive(bytes);

                RiverResponse rr = JsonConvert.DeserializeObject<RiverResponse>(Encoding.UTF8.GetString(bytes, 0, bytesRec));

                if (rr.IsSuccess == false)
                {
                    throw new ApplicationException(rr.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                MessageBox.Show(ex.Message);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
