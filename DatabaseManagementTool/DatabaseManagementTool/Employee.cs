using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagementTool
{
    class Employee
    {
        public int BSN;
        public string Name;
        public string Surname;

        public Employee(int bsn, string name, string surname)
        {
            this.BSN = bsn;
            this.Name = name;
            this.Surname = surname;
        }
    }
}
