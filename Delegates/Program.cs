namespace MyDelegates
{
    class Program { 
        public static void Main(string[] args)
        {
           var emps = EmployeeHelper.get();
            emps.search(e => e.Gender == "F").print().search(e=>e.Name.ToLower().StartsWith("a")).print();
            emps.search(e => e.Gender == "M").print().search(e=>e.Name.ToLower().StartsWith("a")).print();
        }


        
    }
}