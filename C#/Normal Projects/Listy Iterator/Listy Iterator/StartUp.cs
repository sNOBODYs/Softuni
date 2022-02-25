using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    private static ListyIterator<string> _data;
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        var createCommand = input.Split();
        ListyIterator<string> listy = new ListyIterator<string>(createCommand.Skip(1).ToArray());
        input = Console.ReadLine();
        while (input != "END")
        {
            switch (input)
            {
                case "Move": Console.WriteLine(listy.Move());break;
                case "HasNext": Console.WriteLine(listy.HasNext()); break;
                case "Print": listy.Print(); break;
            }
            input = Console.ReadLine();
        }
    }
}

      