using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine()
            .Split(new[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Lake lake = new Lake(input);
        Console.WriteLine(string.Join(", ", lake));
    }
}
