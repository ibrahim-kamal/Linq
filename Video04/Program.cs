using System.Collections;
using System.Linq;
namespace Video04
{
    class Program
    {
        public static void Main(string[] args)
        {
            var emps = Repository.LoadEmployees();
            /*select*/
            // SelectExample(emps);


            /*select Many*/
            //SelectManyExample(emps);

            /*Zip*/
            ZipExample();





        }

        static void SelectExample(IEnumerable<Employee> emps) {

            var empDto = emps.Select(x => {
                return new EmployeeDto
                {
                    name = x.FirstName + " " + x.LastName,
                    skills = String.Join("-", x.Skills)
                };
            });

            foreach (var emp in empDto)
            {
                Console.WriteLine(emp);
            }

        }


        static void SelectManyExample(IEnumerable<Employee> emps)
        {

            var Skills = emps.SelectMany(x => x.Skills);
            // add Distinct
            Skills = Skills.Distinct();


            foreach (var Skill in Skills)
            {
                Console.WriteLine(Skill);
            }

        }

        static void ZipExample()
        {
            List<String> names =  new List<string>(){ "ahmed", "ali", "Tarak" };
            List<double> Sallers = new List<double>() { 3000.0, 4000.0 , 5000.0 };

            var emps = names.Zip(Sallers, (name, sallery) => $"{name} => {sallery}");
            foreach (var emp in emps)
            {
                Console.WriteLine(emp);                
            }
        }

    }
}