using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPIService.Models;

namespace WebAPIService.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmpApiController : ApiController
    {
        CompanyDBEntities entities = new CompanyDBEntities();
        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
            return entities.Employees.ToList();
        }
        [HttpGet]
        public Employee GetEmployee(int id)
        {
            var emp = entities.Employees.Find(id);
            return emp;
        }
        [HttpPost]
        public string InsertEmp(Employee emp)
        {
            entities.Employees.Add(emp);
            entities.SaveChanges();
            return "Employee Inserted Successfully";
        }
        [HttpPut]
        public string UpdateEmp(Employee emp)
        {
            entities.Entry(emp).State = System.Data.Entity.EntityState.Modified;
            entities.SaveChanges();
            return "Employee Updated Successfully";
        }
        [HttpDelete]
        public string DeleteEmp(int employeeId)
        {
            var emp = entities.Employees.Find(employeeId);
            entities.Employees.Remove(emp);
            entities.SaveChanges();
            return "Employee Deleted Successfully";
        }
    }
}
