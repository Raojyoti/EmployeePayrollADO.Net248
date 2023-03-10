using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollAdo.NetProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please select given options");
                Console.WriteLine("1.Get all employees\n" +
                    "2.Update employees salary\n" +
                    "4.Add new employees data\n" +
                    "4.Delete employees \n" +
                    "8.Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Details of Employees are\n----------------------------");
                        EmployeeRepository.GetAllEmployees();
                        Console.Write("\nPress any key to continue...... ");
                        break;
                    case 2:
                        Console.Clear();
                        EmployeePayroll payRoll1 = new EmployeePayroll();
                        payRoll1.Name = "Terisa";
                        payRoll1.Id = 5;
                        payRoll1.Basic_Pay = 3000000;
                        EmployeeRepository.UpdateEmployee(payRoll1);
                        Console.WriteLine("Details of Employees After Update salary are\n-------------------------------------------");
                        EmployeeRepository.GetAllEmployees();
                        Console.Write("\nPress any key to continue...... ");
                        break;
                    case 3:
                        Console.Clear();
                        EmployeePayroll payRoll = new EmployeePayroll();
                        payRoll.Name = "Jyoti";
                        payRoll.Basic_Pay = 85000;
                        payRoll.Address = "Noida";
                        payRoll.Phone_Number = 7805982526;
                        payRoll.Department = "Developer";
                        EmployeeRepository.AddEmployee(payRoll);
                        Console.WriteLine("Details of Employees After Add new employee are\n-------------------------------------------");
                        EmployeeRepository.GetAllEmployees();
                        Console.Write("\nPress any key to continue...... ");
                        break;
                    case 4:
                        Console.Clear();
                        EmployeePayroll payRoll2 = new EmployeePayroll();
                        payRoll2.Id = 7;
                        payRoll2.Name = "Jyoti";
                        EmployeeRepository.DeleteEmployee(payRoll2);
                        Console.WriteLine("Details of Employees After delete employee are\n-------------------------------------------");
                        EmployeeRepository.GetAllEmployees();
                        Console.Write("\nPress any key to continue...... ");
                        break;
                    case 8:
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please select only given options");
                        Console.Write("\nPress any key to continue...... ");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
