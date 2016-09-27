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

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public object Find(int id)
        {
            throw new NotImplementedException();
        }

        public object FindAll()
        {
            throw new NotImplementedException();
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
