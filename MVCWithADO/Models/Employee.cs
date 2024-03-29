namespace MVCWithADO.Models
{
    //POCO/Entity/Model
    public class Employee
    {
        public int Eno { get; set; }
        public string Ename { get; set; }
        public double Salary { get; set; }
        public string Job { get; set; }
        public int DeptID { get; set; }
    }
}