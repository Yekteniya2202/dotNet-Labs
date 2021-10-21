using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryRivers;
using Newtonsoft.Json;

namespace Server
{
    class Program
    {
        private static ConcurrentDictionary<string, River> _rivers = new ConcurrentDictionary<string, River>();
        static void Main(string[] args)
        {
            // Устанавливаем для сокета локальную конечную точку
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);

            // Создаем сокет Tcp/Ip
            Socket sListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            // Назначаем сокет локальной конечной точке и слушаем входящие сокеты
            try
            {
                sListener.Bind(ipEndPoint);
                sListener.Listen(10);
                // Начинаем слушать соединения
                while (true)
                {
                    Console.WriteLine("Ожидаем соединение через порт {0}", ipEndPoint);
                    // Программа приостанавливается, ожидая входящее соединение
                    Socket socket = sListener.Accept();
                    Task taskSocket = new Task(Action, socket);
                    taskSocket.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void Action(object o)
        {
            Socket socket = o as Socket;
            if (socket != null)
            {
                while (true)
                {
                    try
                    {
                        // Мы дождались клиента, пытающегося с нами соединиться
                        byte[] bytes = new byte[10240];
                        int bytesRec = socket.Receive(bytes);
                        string json = Encoding.UTF8.GetString(bytes, 0, bytesRec);
                        RiverResponse response = new RiverResponse { IsSuccess = false };
                        try
                        {
                            var request = JsonConvert.DeserializeObject<RiverRequest>(json);
                            if (request != null)
                            {
                                response.Key = request.Key;
                                River river;
                                switch (request.Type)
                                {
                                    case RiverRequestType.Get:
                                        if (_rivers.TryGetValue(request.Key, out river))
                                        {
                                            response.River = river;
                                            response.IsSuccess = true;
                                        }
                                        else
                                        {
                                            response.ErrorMessage = "Ключ не найден";
                                        }
                                        break;
                                    case RiverRequestType.Add:
                                        if (_rivers.ContainsKey(request.Key))
                                        {
                                            response.ErrorMessage = "Город с таким ключем уже существует";
                                        }
                                        else
                                        {
                                            _rivers.AddOrUpdate(request.Key, request.River, (s, city1) => request.River);
                                            response.IsSuccess = true;
                                        }
                                        break;
                                    case RiverRequestType.Update:
                                        if (_rivers.ContainsKey(request.Key))
                                        {
                                            _rivers.AddOrUpdate(request.Key, request.River, (s, river1) => request.River);
                                            response.IsSuccess = true;
                                        }
                                        else
                                        {
                                            response.ErrorMessage = "Город с таким ключем не существует";
                                        }
                                        break;
                                    case RiverRequestType.Remove:
                                        if (_rivers.ContainsKey(request.Key))
                                        {
                                            if (_rivers.TryRemove(request.Key, out river))
                                            {
                                                response.IsSuccess = true;
                                            }
                                            else
                                            {
                                                response.ErrorMessage = "Не удалось удалить город";
                                            }
                                        }
                                        else
                                        {
                                            response.ErrorMessage = "Город с таким ключем не существует";
                                        }
                                        break;
                                    default:
                                        throw new ArgumentOutOfRangeException();
                                }
                            }
                        }
                        catch (Exception exception)
                        {
                            response.ErrorMessage = exception.Message;
                        }
                        // Показываем данные на консоли
                        Console.WriteLine("Полученный json: " + json);
                        // Отправляем ответ клиенту\
                        var jsonResponse = JsonConvert.SerializeObject(response);
                        byte[] msg = Encoding.UTF8.GetBytes(jsonResponse);
                        Console.Write("Отправленный json: " + jsonResponse);
                        socket.Send(msg);
                    }
                    catch (Exception)
                    {
                        break;
                    }
                }
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
        }
    }
}