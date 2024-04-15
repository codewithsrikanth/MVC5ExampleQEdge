using RepositoryInMVC.RepositoryLayer.ViewModels;
using System.Collections.Generic;

namespace RepositoryInMVC.RepositoryLayer.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<EmpViewModel> GetEmployees();
        EmpViewModel GetSingleEmp(int id);
        void InsertEmployee(EmpViewModel employee);
        void UpdateEmployee(EmpViewModel employee);
        void DeleteEmployee(int id);
        void SaveChanges();
    }
}
