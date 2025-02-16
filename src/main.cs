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

    List<string> builtins = ["exit", "echo", "type"];

    switch (cmd[0])
    {
        case "exit":
            Environment.Exit(int.Parse(cmd[1]));
            break;
        case "echo":
            for (int i = 1; i < cmd.Length; i++)
            {
                Console.Write(cmd[i]);
                if (i < cmd.Length - 1)
                    Console.Write(" ");
            }
            break;
        case "type":
            if (cmd.Length == 0)
                break;
            if (builtins.Contains(cmd[1]))
                Console.Write(cmd[1] + " is a shell command");
            else
                Console.Write(cmd[1] + ": not found");
            break;
        default:
            Console.Write($"{s}: command not found");
            break;
    }
    Console.Write("\n");


}
