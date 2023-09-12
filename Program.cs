namespace Personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is registration for employee of K restaurant");
            Console.WriteLine("enter employee's full name: ");
            string fullname = Console.ReadLine();
            Console.WriteLine("enter employee's monthly salary: ");
            string salary = Console.ReadLine();
            Console.WriteLine($"{fullname} has sucessfully registered with monthly salary {salary}");
        }
    }
}