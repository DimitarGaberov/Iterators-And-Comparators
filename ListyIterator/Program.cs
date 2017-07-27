using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        var createCommand = Console.ReadLine().Split(' ');
        ListyIterator<string> listyIterator;

        if (createCommand.Length > 1)
        {
            var elements = createCommand.Skip(1).ToList();
            listyIterator = new ListyIterator<string>(elements);
        }
        else
        {
            listyIterator = new ListyIterator<string>();
        }

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            switch (input)
            {
                case "Move":
                    Console.WriteLine(listyIterator.Move());
                    break;
                case "Print":
                    try
                    {
                        Console.WriteLine(listyIterator.Print());
                    }
                    catch (InvalidOperationException ioe)
                    {
                        Console.WriteLine(ioe.Message);
                    }
                    break;
                case "HasNext":
                    Console.WriteLine(listyIterator.HasNext());
                    break;
                case "PrintAll":
                    Console.WriteLine(string.Join(" ", listyIterator));
                    break;
            }
        }
    }
}
