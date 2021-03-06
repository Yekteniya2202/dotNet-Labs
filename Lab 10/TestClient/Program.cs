using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ClassLibraryCities;
using Newtonsoft.Json;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
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
            while (true)
            {
                try
                {
                    CityRequest request = null;
                    Console.Write("Действие (add, get): ");
                    string action = Console.ReadLine();
                    if (action == "add")
                    {
                        string title = Console.ReadLine();
                        request = new CityRequest
                        {
                            City = new City {Title = title},
                            Key = title,
                            Type = CityRequestType.Add
                        };
                    }
                    else if (action == "get")
                    {
                        string key = Console.ReadLine();
                        request = new CityRequest
                        {
                            Key = key,
                            Type = CityRequestType.Get
                        };
                    }
                    else
                    {
                        continue;
                    }
                    string jsonRequest = JsonConvert.SerializeObject(request);
                    byte[] msg = Encoding.UTF8.GetBytes(jsonRequest);
                    // Отправляем данные через сокет
                    sender.Send(msg);
                    // Получаем ответ от сервера
                    int bytesRec = sender.Receive(bytes);
                    Console.WriteLine("Запрос к серверу: {0}\n\n", jsonRequest);
                    Console.WriteLine("Ответ от сервера: {0}\n\n", Encoding.UTF8.GetString(bytes, 0, bytesRec));
                }
                catch (Exception)
                {
                    break;
                }
            }
            // Освобождаем сокет
            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
        }
    }
}