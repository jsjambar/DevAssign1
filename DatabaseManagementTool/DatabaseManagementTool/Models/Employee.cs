using DatabaseManagementTool.Classes;
using DatabaseManagementTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagementTool
{
    public class Employee : ORM
    { 
        public int BSN { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        Database database = new Database();

        public void Create(object model)
        {
            Employee insertable_employee = new Employee { BSN = BSN, Name = Name, Surname = Surname };
            string create_employee = $"INSERT INTO `employees` (`bsn`, `first_name`, `last_name`) VALUES ({BSN} ,'{Name}', '{Surname}')";
            database.DoQuery(create_employee);
        }

        public void Delete(int bsn)
        {
        }

        public object Find(int bsn)
        {
            string find_employee = $"SELECT * FROM `employees` WHERE `boolean_deleted` = 0 and `bsn` = {bsn}";
            List<Employee> employees = database.employeeQuery(find_employee);

            return employees;
        }

        public object FindAll()
        {
            string getall_employee = "SELECT * FROM `employees`";
            List<Employee> employees = database.employeeQuery(getall_employee);

            return employees;
        }

        public object FindLast()
        {
            throw new NotImplementedException();
        }

        public void Update(object model)
        {
            throw new NotImplementedException();
        }
    }
}
