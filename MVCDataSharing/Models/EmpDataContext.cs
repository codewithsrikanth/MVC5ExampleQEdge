using MVCDataSharing.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDataSharing.Models
{
    public static class EmpDataContext
    {
        public static List<Emp> GetEmployees()
        {
            return new List<Emp>()
            {
                new Emp(){Eno=101,EmpName="Srikanth",EmpSalary=12000},
                new Emp(){Eno=102,EmpName="Suresh",EmpSalary=8500},
                new Emp(){Eno=103,EmpName="Ramesh",EmpSalary=9600},
                new Emp(){Eno=104,EmpName="Mahesh",EmpSalary=7589},
                new Emp(){Eno=105,EmpName="Raju",EmpSalary=9654},
                new Emp(){Eno=106,EmpName="Abhi",EmpSalary=4587}
            };
        }
        public static Emp GetEmployee(int eno)
        {
            List<Emp> emps = GetEmployees();
            foreach (var item in emps)
            {
                if(item.Eno == eno)
                {
                    return item;
                }
            }
            return new Emp();
        }
    }
}