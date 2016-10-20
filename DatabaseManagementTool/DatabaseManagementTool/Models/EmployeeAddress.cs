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

        Employee Employee { get; set; }
        Address Address { get; set; }
        PostalCode PostalCode { get; set; }
        Country Country { get; set; }

        public void Create(object model)
        {
            throw new NotImplementedException();
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
