using System.Net;
using System.Net.Sockets;

DateTime now = DateTime.Now;
string path = $"{now}_Server.txt".Replace(' ', '_').Replace(':', '-');
using (StreamWriter writer = new StreamWriter(path, true)) { }
ServerObject server = new ServerObject(path);// создаем сервер
await server.ListenAsync(); // запускаем сервер