using System.Collections.Generic;

namespace CodeFirstEF.Models
{
    public class EmpDeptViewModel
    {
        public List<Employee> Emps { get; set; }
        public List<Dept> Depts { get; set; }
    }
}