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
        object Find(int id);
        void Delete(int id);
        void Create(object model);
        void Update(object model);
        object FindAll();
        object FindLast();
    }

    //class ModelFactory
    //{
    //    public IModel Create(int id)
    //    {
    //        if(id == 1)
    //        {
    //            return new Employee();
    //        }

    //        throw new Exception("Model can't be found");
    //    }
    //}
}
