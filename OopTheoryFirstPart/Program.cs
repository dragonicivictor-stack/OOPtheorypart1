using OopTheoryLibrary;

namespace OopTheoryFirstPart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John Doe", new DateTime(1993, 10, 12));
            person.PresentYourself();

            person.ChangePersonalData("John Doee");
            person.PresentYourself();

            IntArray array = new IntArray(new[] { 1, 2, 3 });
            Console.WriteLine("Sum=" + array.Sum());
            Console.WriteLine("Element at index 0=" + array[0]);

        }
    }
}