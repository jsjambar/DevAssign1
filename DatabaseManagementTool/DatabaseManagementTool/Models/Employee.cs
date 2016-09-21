using DatabaseManagementTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagementTool
{
    public class Employee : IModel
    { 
        public int BSN { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public void Create(object model)
        {
            throw new NotImplementedException();
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
