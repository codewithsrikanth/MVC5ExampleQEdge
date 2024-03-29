using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MVCWithADO.Models
{
    public class EmployeeDataContext
    {
        SqlConnection _connection;
        SqlCommand _command;
        SqlDataReader _reader;
        public EmployeeDataContext()
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CompanyDBConn"].ConnectionString);
        }
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            _command = new SqlCommand("sp_SelectEmps", _connection);
            _command.CommandType = CommandType.StoredProcedure;
            _connection.Open();
            _reader =  _command.ExecuteReader();
            if (_reader.HasRows)
            {
                while (_reader.Read())
                {
                    Employee emp = new Employee();
                    emp.Eno =Convert.ToInt32(_reader["Eno"]);
                    emp.Ename =Convert.ToString(_reader["Ename"]);
                    emp.Salary =Convert.ToDouble(_reader["Salary"]);
                    emp.Job =Convert.ToString(_reader["Job"]);
                    emp.DeptID =Convert.ToInt32(_reader["DeptID"]);
                    employees.Add(emp);
                }
            }
            _reader.Close();
            _connection.Close();
            return employees;
        }
        public int InsertEmployee(Employee emp)
        {
            _command = new SqlCommand("InsertEmp", _connection);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@eno", emp.Eno);
            _command.Parameters.AddWithValue("@empName", emp.Ename);
            _command.Parameters.AddWithValue("@sal", emp.Salary);
            _command.Parameters.AddWithValue("@job", emp.Job);
            _command.Parameters.AddWithValue("@deptNo", emp.DeptID);
            _connection.Open();
            int recCount = _command.ExecuteNonQuery();
            _connection.Close();
            return recCount;
        }

        public Employee GetEmployee(int eno)
        {
            Employee emp = new Employee();
            _command = new SqlCommand("sp_SelectEmp", _connection);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@eno", eno);
            _connection.Open();
            _reader =  _command.ExecuteReader();
            if (_reader.HasRows)
            {
                if (_reader.Read())
                {                   
                    emp.Eno =Convert.ToInt32(_reader["Eno"]);
                    emp.Ename =Convert.ToString(_reader["Ename"]);
                    emp.Salary =Convert.ToDouble(_reader["Salary"]);
                    emp.Job =Convert.ToString(_reader["Job"]);
                    emp.DeptID =Convert.ToInt32(_reader["DeptID"]);
                }
            }
            _reader.Close();
            _connection.Close();
            return emp;            
        }
        public int UpdateEmp(Employee emp)
        {
            _command = new SqlCommand("sp_UpdateEmp", _connection);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@eno", emp.Eno);
            _command.Parameters.AddWithValue("@empName", emp.Ename);
            _command.Parameters.AddWithValue("@sal", emp.Salary);
            _command.Parameters.AddWithValue("@job", emp.Job);
            _command.Parameters.AddWithValue("@deptNo", emp.DeptID);
            _connection.Open();
            int recCount = _command.ExecuteNonQuery();
            _connection.Close();
            return recCount;
        }
    }
}