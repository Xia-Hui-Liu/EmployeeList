namespace EmployeeList
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            while (true)
            {
                Console.WriteLine("Enter employee name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter employee salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

                employees.Add(new Employee()
                {
                    Name = name,
                    Salary = salary
                }
                );
                Console.WriteLine("New employee registered sucessfully!\n");
                Console.WriteLine($"Name: {name}, Salary: {salary}");
                break;

            }
        }
    }
}