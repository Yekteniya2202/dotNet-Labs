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

namespace RiverForm
{
    public partial class MainForm : Form
    {
        private byte[] bytes = new byte[10240];
        private IPHostEntry ipHost;
        private IPAddress ipAddr;
        private IPEndPoint ipEndPoint;
        private Socket socket;
        private RiverRequest request;
        private RiverResponse response;

        public MainForm()
        {
            InitializeComponent();
            ipHost = Dns.GetHostEntry("localhost");
            ipAddr = ipHost.AddressList[0];
            ipEndPoint = new IPEndPoint(ipAddr, 11000);

            socket = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                socket.Connect(ipEndPoint);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нет соединения с сервером!");
            }
        }

        private void getByKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDeleteForm form = new GetDeleteForm("Получить");

            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    request = new RiverRequest
                    {
                        Key = form.Key,
                        Type = RiverRequestType.Get
                    };

                    string jsonRequest = JsonConvert.SerializeObject(request);
                    byte[] msg = Encoding.UTF8.GetBytes(jsonRequest);

                    socket.Send(msg);

                    int bytesRec = socket.Receive(bytes);

                    response = JsonConvert.DeserializeObject<RiverResponse>(Encoding.UTF8.GetString(bytes, 0, bytesRec));

                    if (!response.IsSuccess)
                        throw new Exception(response.ErrorMessage);

                    MessageBox.Show("Полученная река:\n\n" + response.River.ToString(), "Удачно");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
        }

        private void deleteByKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDeleteForm form = new GetDeleteForm("Удалить");

            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    request = new RiverRequest
                    {
                        Key = form.Key,
                        Type = RiverRequestType.Remove
                    };

                    string jsonRequest = JsonConvert.SerializeObject(request);
                    byte[] msg = Encoding.UTF8.GetBytes(jsonRequest);

                    socket.Send(msg);

                    int bytesRec = socket.Receive(bytes);

                    response = JsonConvert.DeserializeObject<RiverResponse>(Encoding.UTF8.GetString(bytes, 0, bytesRec));

                    if (!response.IsSuccess)
                        throw new Exception(response.ErrorMessage);

                    MessageBox.Show("Удаление: удачно");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
        }

        private void updateByKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateForm form = new UpdateForm("Обновить");

            form.River = new River();
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (!form.River.IsValid())
                        throw new Exception("Неправильно заполнена информация о банке!");

                    request = new RiverRequest
                    {
                        Key = form.Key,
                        Type = RiverRequestType.Update,
                        River = form.River
                    };

                    string jsonRequest = JsonConvert.SerializeObject(request);
                    byte[] msg = Encoding.UTF8.GetBytes(jsonRequest);

                    socket.Send(msg);

                    int bytesRec = socket.Receive(bytes);

                    response = JsonConvert.DeserializeObject<RiverResponse>(Encoding.UTF8.GetString(bytes, 0, bytesRec));

                    if (!response.IsSuccess)
                        throw new Exception(response.ErrorMessage);

                    MessageBox.Show("Река успешно обновлена", "Удачно");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
        }

        private void addWithKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateForm form = new UpdateForm("Добавить");
            form.River = new River();
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (!form.River.IsValid())
                        throw new Exception("Неправильно заполнена информация о реке");

                    request = new RiverRequest
                    {
                        Key = form.Key,
                        Type = RiverRequestType.Add,
                        River = form.River
                    };

                    string jsonRequest = JsonConvert.SerializeObject(request);
                    byte[] msg = Encoding.UTF8.GetBytes(jsonRequest);

                    socket.Send(msg);

                    int bytesRec = socket.Receive(bytes);

                    response = JsonConvert.DeserializeObject<RiverResponse>(Encoding.UTF8.GetString(bytes, 0, bytesRec));

                    if (!response.IsSuccess)
                        throw new Exception(response.ErrorMessage);

                    MessageBox.Show("Река успешно добавлена", "Удачно");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
        }
    }
}
