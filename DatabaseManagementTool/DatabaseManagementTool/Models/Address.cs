using DatabaseManagementTool.Classes;
using DatabaseManagementTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagementTool
{
    public class Address : ORM    {
        public int ID { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        Database database = new Database();

        public void Create(object model)
        {
            Address insertable_address = new Address {Street = Street, Number = Number };
            string create_address = $"INSERT INTO `addresses` (`name`, `street`) VALUES ('{insertable_address.Street}', '{insertable_address.Number}')";
            this.database.DoQuery(create_address);
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
