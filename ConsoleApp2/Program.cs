namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            var person = new Person() { Name = name };

            Console.WriteLine("Hello, " + person.Name);
        }
    }
}