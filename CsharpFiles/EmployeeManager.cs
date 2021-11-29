using System;
namespace JaiBalayya
{
    public class EmployeeManager : IEmployeeOperations
    {
        private Employee[] allemployee = new Employee[1];
        public void Add(Employee e)
        {
            foreach (Employee employee in allemployee)
            {
                Console.WriteLine("Enter Employee Name");
                e.Name = Console.ReadLine();
                Console.WriteLine("Enter Adress Of Employee : ");
                e.Adress = Console.ReadLine();
                Console.WriteLine("Enter Id Of Employee :");
                e.EmployeeId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Salary Of Employee : ");
                e.Salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Department Of Employee : ");
                e.Department = Console.ReadLine();
            }
        }
        public void Delete(int id)
        {
            //Delete the employee from array
            Console.WriteLine("You Deletd the " + allemployee[id]);
        }
        public void Display()
        {
            Console.Write($"Employee Name is {allemployee[0].Name}\n");
            Console.Write($"Employee ID is {allemployee[0].EmployeeId}\n");
            Console.Write($"Employee Department is {allemployee[0].Department}\n");
            Console.Write($"Employee Adress is {allemployee[0].Adress}\n");
            Console.Write($"Employee Salary is {allemployee[0].Salary}\n");
        }
        public Employee Find(int id)
        {
            return allemployee[id];
        }
    }
}
