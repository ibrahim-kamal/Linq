using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegates
{
    public static class EmployeeHelper
    {
        public static List<Employee> get() { 
            return new List<Employee>() {
                new Employee { Id=1 ,Name="Fatma" , Gender= "F" , TotalSales=1500m},
                new Employee { Id=2 ,Name="Ali" , Gender= "M" , TotalSales=2500m},
                new Employee { Id=3 ,Name="Ahmed" , Gender= "M" , TotalSales=3500m},
                new Employee { Id=4 ,Name="Eman" , Gender= "F" , TotalSales=4500m},
                new Employee { Id=5 ,Name="Adel" , Gender= "M" , TotalSales=5500m},
                new Employee { Id=6 ,Name="Aya" , Gender= "F" , TotalSales=6500m},
                new Employee { Id=7 ,Name="Shabban" , Gender= "M" , TotalSales=7500m},
                new Employee { Id=8 ,Name="Menna" , Gender= "F" , TotalSales=8500m}
            };
        }


        public static IEnumerable<Employee> search(this IEnumerable<Employee> emps , Predicate<Employee> keySearch) {
            foreach (var emp in emps)
            {
                
                if (keySearch(emp)) {
                    yield return emp;
                }
            }
        }
        public static IEnumerable<Employee> print(this IEnumerable<Employee> emps)
        {
            Console.WriteLine("Employees List");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Name\t\tGender");
            foreach (var emp in emps)
            {
                Console.WriteLine($"{emp.Name}\t\t{emp.Gender}");                
            }
            return emps;
        }
    }
}
