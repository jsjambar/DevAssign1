using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagementTool.Classes
{
    class QueryBuilder
    {
        string DefaultSelectQuery = $"SELECT ";
        string DefaultSelector = $" * ";
        string DefaultFrom = $" FROM ";
        string DefaultTable = $" `employee` ";
        string DefaultWhere = $" WHERE ";
        string DefaultID = $" `id` = ";
        string DefaultIDNumber = $" 1; ";

        public QueryBuilder()
        {
            this.GetFullQuery();
        }

        public string GetFullQuery()
        {
            return this.DefaultSelectQuery + this.DefaultSelector + this.DefaultFrom + this.DefaultTable + this.DefaultWhere
                + this.DefaultID + this.DefaultIDNumber;
        }
    }
}
