using System;
using EmployeeDetails;

namespace Program
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // EmployeeDetails.Employee baseClass1 = new EmployeeDetails.Employee("Harsh", "Patel", 10000.00);
            // EmployeeDetails.Employee baseClass2 = new EmployeeDetails.Employee("Kush", "Parmar", 15000.00);  

            EmployeeDetails.PermanentEmployee deriveClass1 = new EmployeeDetails.PermanentEmployee("HARSH", "PATEL", 100000.00, "20-02-2022", "20-02-2032");
            EmployeeDetails.PermanentEmployee deriveClass2 = new EmployeeDetails.PermanentEmployee("KUSH", "PARMAR", 150000.00, "10-01-2021", "10-03-2031");

            Console.WriteLine($"---FIRST EMPLOYEE---");
            Console.WriteLine(deriveClass1);

            Console.WriteLine($"---SECOND EMPLOYEE---");
            Console.WriteLine(deriveClass2);

            Console.WriteLine($"---------------After Getting Rasie of 20%---------------");

            deriveClass1.getRaise(20);
            deriveClass2.getRaise(20);

            Console.WriteLine($"---FIRST EMPLOYEE---");
            Console.WriteLine(deriveClass1);

            Console.WriteLine($"---SECOND EMPLOYEE---");
            Console.WriteLine(deriveClass2);

        }
    }
}