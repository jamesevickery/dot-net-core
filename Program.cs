using System;

namespace ConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            Client client2 = new Client("Arthur", "Ford");
            Display<Client>(client2);
            Console.WriteLine();
        }
        private static void Display<T>(T person) where T : Person
        {
            person.Display();
        }
    }

    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string lName, string fName)
        {
            FirstName = fName;
            LastName = lName;
        }
        public abstract void Display();
    }

    class Client : Person
    {
        public Client(string lName, string fName)
        : base(fName, lName)
        {
        }
        public override void Display()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
