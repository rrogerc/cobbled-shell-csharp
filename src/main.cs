using System.Net;
using System.Net.Sockets;

while (true)
{
    Console.Write("$ ");

    var s = Console.ReadLine();
    if (s == null)
        continue;

    var cmd = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    if (cmd.Length == 0)
        continue;

    if (cmd[0] == "exit")
        Environment.Exit(int.Parse(cmd[1]));

    Console.Write($"{s}: command not found\n");
}
