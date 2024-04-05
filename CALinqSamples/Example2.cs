
namespace CALinqSamples
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
    }
    class Example2
    {
        static void Main(string[] args)
        {
            var employees = GetEmpData();

            //var emps = from emp in employees select emp;
            //var emps = from emp in employees where emp.Salary >= 25000 select emp;
            //var emps = from emp in employees where emp.EmpName.StartsWith("S") select emp;
            var emps = from emp in employees orderby emp.EmpID descending select emp;

            Console.WriteLine("Employee Details are: ");
            foreach (var item in emps)
            {
                Console.WriteLine(item.EmpID + " " + item.EmpName + " " + item.Salary);
            }
        }

        private static List<Employee> GetEmpData()
        {
            return new List<Employee>()
            {
                new Employee(){EmpID=101,EmpName="Srikanth",Salary=25000},
                new Employee(){EmpID=106,EmpName="Sai",Salary=23000},
                new Employee(){EmpID=103,EmpName="Suresh",Salary=18000},
                new Employee(){EmpID=102,EmpName="Ramesh",Salary=57000},
                new Employee(){EmpID=105,EmpName="Scott",Salary=65000},
                new Employee(){EmpID=104,EmpName="Jhon",Salary=12000}
            };
        }
    }
}
