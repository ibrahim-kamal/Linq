using System.Linq;
namespace MyDelegates
{
    class Program
    {
        public static void Main(string[] args)
        {
            //var emps = EmployeeHelper.get();
            //emps.Where(e => e.Gender == "F").print().Where(e => e.Name.ToLower().StartsWith("a")).print();
            //emps.Where(e => e.Gender == "M").print().Where(e => e.Name.ToLower().StartsWith("a")).print();


            List<int> numbers= new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            var evanNumbersUsingExtensionWhere = numbers.Where(x => x % 2 == 0);
            var evanNumbersUsingEnumerableWhere = Enumerable.Where(numbers , x => x % 2 == 0);
            var evanNumbersUsingQuerySyntax = 
                    from n in numbers
                    where n % 2 == 0
                    select n;

            numbers.Add(10);
            numbers.Add(12);
            numbers.Remove(4);

            foreach (int n in evanNumbersUsingExtensionWhere)
                Console.Write(n + ",");
            
            Console.WriteLine("");
            Console.WriteLine("");
            foreach (int n in evanNumbersUsingEnumerableWhere)
                Console.Write(n + ",");
            
            Console.WriteLine("");
            Console.WriteLine("");
            foreach (int n in evanNumbersUsingQuerySyntax)
                Console.Write(n + ",");

        }



    }
}