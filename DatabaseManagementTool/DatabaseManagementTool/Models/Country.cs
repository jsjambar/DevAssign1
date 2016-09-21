using DatabaseManagementTool.Classes;
using DatabaseManagementTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagementTool
{
    public class Country : IModel
    {
        public int ID { get; set; }
        public string Name { get; set; }

        Database Database = new Database();

        public void Create(object model)
        {
            Database.AddCountry(this);
        }

        public object Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
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
