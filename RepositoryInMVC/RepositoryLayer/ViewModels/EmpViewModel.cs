using System.Web;

namespace RepositoryInMVC.RepositoryLayer.ViewModels
{
    public class EmpViewModel
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
        public string Designation { get; set; }
        public int? DepartmentID { get; set; }
    }
}