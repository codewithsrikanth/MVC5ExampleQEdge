using RepositoryInMVC.Models;
using RepositoryInMVC.RepositoryLayer.Interfaces;
using RepositoryInMVC.RepositoryLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryInMVC.RepositoryLayer.Implementation
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private CompanyDBEntities _context;

        public EmployeeRepository()
        {
            _context = new CompanyDBEntities();
        }

        public void DeleteEmployee(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<EmpViewModel> GetEmployees()
        {
            List<EmpViewModel> employees = new List<EmpViewModel>();
            IEnumerable<Employee> emps = _context.Employees.ToList();
            foreach (var item in emps)
            {
                EmpViewModel model = new EmpViewModel();
                model.EmpNo = item.Eno;
                model.EmpName = item.Ename;
                model.Salary = Convert.ToDouble(item.Salary);
                model.Designation = item.Job;
                model.DepartmentID = item.DeptID;
                employees.Add(model);
            }
            return employees;
        }

        public EmpViewModel GetSingleEmp(int id)
        {
            throw new System.NotImplementedException();
        }

        public void InsertEmployee(EmpViewModel employee)
        {
            _context.Employees.Add(new Employee()
            {
                Eno = employee.EmpNo,
                Ename = employee.EmpName,
                Job = employee.Designation,
                Salary = Convert.ToDecimal(employee.Salary),
                DeptID = employee.DepartmentID
            });
            SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void UpdateEmployee(EmpViewModel employee)
        {
            throw new System.NotImplementedException();
        }
    }
}