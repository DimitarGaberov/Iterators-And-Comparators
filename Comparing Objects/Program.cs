using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        List<Person> people = new List<Person>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            var inputTokens = input.Split(' ');
            var name = inputTokens[0];
            var age = int.Parse(inputTokens[1]);
            var town = inputTokens[2];

            Person person = new Person(name, age, town);
            people.Add(person);
        }

        int personInCollectionIndex = int.Parse(Console.ReadLine());
        var personInCollection = people[personInCollectionIndex - 1];
        people.RemoveAt(personInCollectionIndex - 1);

        int numberOfEqualPeople = 1;
        int numberOfUnequalPeople = people.Count;
        int totalPeople = people.Count + 1;

        if (!people.Where(p => p.CompareTo(personInCollection) == 0).Any())
        {
            Console.WriteLine("No matches");
        }
        else
        {
            foreach (var person in people)
            {
                if (person.CompareTo(personInCollection) == 0)
                {
                    numberOfEqualPeople++;
                    numberOfUnequalPeople--;
                }
            }

            Console.WriteLine($"{numberOfEqualPeople} {numberOfUnequalPeople} {totalPeople}");
        }
    }
}