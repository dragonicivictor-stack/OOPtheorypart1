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

            /* Method overloading */
            ConsoleHelper.PrintMessage("This is a message");
            ConsoleHelper.PrintMessage("This is a message", "Label");
            ConsoleHelper.PrintMessage("This is a message", 2);

            int[] array2 = new[] { 1, 2, 3, 4 };
            RecursivityHelper.Iterate(array2);
        }
    }
}