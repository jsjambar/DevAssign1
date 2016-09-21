using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagementTool.Models
{

    // Interface for ORM-like methods
    interface IModel
    {
        void Get(int id);
        void Delete(int id);
        void Create(Object model);
        void GetFirst();
        void GetLast();
    }

    class ModelFactory
    {
        public IModel Create(int id)
        {
            if(id == 1)
            {
                return new Employee();
            }

            throw new Exception("Model can't be found");
        }
    }
}
