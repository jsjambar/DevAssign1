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
