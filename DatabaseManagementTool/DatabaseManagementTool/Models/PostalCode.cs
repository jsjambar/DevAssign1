using DatabaseManagementTool.Classes;
using DatabaseManagementTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagementTool
{
    public class PostalCode : ORM
    {
        public int ID { get; set; }
        public string Code { get; set; }

        Database database = new Database();

        public object Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(object model)
        {
            PostalCode insertable_postal_code = new PostalCode { Code = Code };
            string create_postal_code = $"INSERT INTO `postal_codes` (`code`) VALUES ('{insertable_postal_code.Code}')";
            this.database.DoQuery(create_postal_code);
        }

        public void Update(object model)
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
    }
}
