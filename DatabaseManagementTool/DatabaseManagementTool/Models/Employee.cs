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
        public string Address { get; set; }
        public string Education { get; set; }
        public string Job { get; set; }

        Database database = new Database();

        public void Create(object model)
        {
            Employee insertable_employee = new Employee { BSN = BSN, Name = Name, Surname = Surname, Address = Address, Education = Education, Job = Job };
            string create_employee = $"INSERT INTO `employees` (`bsn`, `first_name`, `last_name`, `address`, `education`, `job`) VALUES ({BSN} ,'{Name}', '{Surname}', '{Address}', '{Education}', '{Job}')";
            database.DoQuery(create_employee);
        }

        public void Delete(int bsn)
        {
            string delete_employee = $"UPDATE `employees` SET `boolean_deleted` = 1 WHERE `bsn` = '{bsn}'";
            database.DoQuery(delete_employee);
        }

        public object Find(int bsn)
        {
            string find_employee = $"SELECT * FROM `employees` WHERE `boolean_deleted` = 0 and `bsn` = {bsn}";
            List<Employee> employees = database.employeeQuery(find_employee);

            return employees;
        }

        public object FindAll()
        {
            string getall_employee = "SELECT * FROM `employees` WHERE `boolean_deleted` = 0";
            List<Employee> employees = database.employeeQuery(getall_employee);

            return employees;
        }

        public object FindLast()
        {
            throw new NotImplementedException();
        }

        public void Update(object model)
        {
            Employee employee = (Employee)model;
            string update_employee = $"UPDATE `employees` SET `first_name` = '{employee.Name}', `last_name` = '{employee.Surname}', `address` = '{employee.Address}', `education` = '{employee.Education}', `job` = '{employee.Job}' WHERE `bsn` = '{employee.BSN}'";
            database.DoQuery(update_employee);
        }
    }
}
