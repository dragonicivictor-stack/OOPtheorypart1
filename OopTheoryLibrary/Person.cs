using System;

namespace OopTheoryLibrary
{
    public class Person
    {
        public string Name { get; private set; } = string.Empty;

        public DateTime DateOfBirth { get; } = DateTime.Today;

        public Person(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public void ChangePersonalData(string name)
        {
            Name = name;
        }

        public void PresentYourself()
        {
            Console.WriteLine($"Hi, my name is {Name}, and I was born on {DateOfBirth:yyyy-MM-dd}");
        }

        public void PrintCanIVote()
        {
            if ((DateTime.Now.Year - DateOfBirth.Year) >= 18)
            {
                Console.WriteLine("Pot vota!");
            }
            else
            {
                Console.WriteLine("Nu pot vota!");
            }
        }
    }
}
