using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagementTool.Models
{

    // Interface for ORM-like methods
    interface ORM
    {
        object Find(int id);
        void Delete(int id);
        void Create(object model);
        void Update(object model);
        object FindAll();
        object FindLast();
    }
}
