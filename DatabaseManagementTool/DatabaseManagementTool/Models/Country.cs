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

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Get(int id)
        {
            throw new NotImplementedException();
        }

        public void GetFirst()
        {
            throw new NotImplementedException();
        }

        public void GetLast()
        {
            throw new NotImplementedException();
        }
    }
}
