using DatabaseManagementTool.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagementTool.Models
{
    class EmployeeAddress : ORM
    {
        Database Database = new Database();

        int EmployeeID { get; set; }
        int AddressID { get; set; }
        int PostalCodeID { get; set; }
        int CountryID { get; set; }

        Employee Employee { get; set; }
        Address Address { get; set; }
        PostalCode PostalCode { get; set; }
        Country Country { get; set; }

        public void Create(object model)
        {
            EmployeeAddress employee_addres = new EmployeeAddress { EmployeeID = 1, AddressID = 1, PostalCodeID = 1, CountryID = 1 };
            string create_employee_address = "INSERT INTO `employee_addresses` (`employee`, `address`, `postal_code`, `country`) VALUES ()";
            this.Database.DoQuery(create_employee_address);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public object Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<object> FindAll()
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
