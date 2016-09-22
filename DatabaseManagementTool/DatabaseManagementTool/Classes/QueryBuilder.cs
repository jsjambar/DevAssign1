using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagementTool.Classes
{
    //class QueryBuilder
    //{
    //    string DefaultSelectQuery = $"SELECT ";
    //    string DefaultSelector = $" * ";
    //    string DefaultFrom = $" FROM ";
    //    string DefaultTable = $" `employee` ";
    //    string DefaultWhere = $" WHERE ";
    //    string DefaultID = $" `id` = ";
    //    string DefaultIDNumber = $" 1; ";

    //    public QueryBuilder()
    //    {
    //        this.GetFullQuery();
    //    }

    //    public string GetFullQuery()
    //    {
    //        return this.DefaultSelectQuery + this.DefaultSelector + this.DefaultFrom + this.DefaultTable + this.DefaultWhere
    //            + this.DefaultID + this.DefaultIDNumber;
    //    }
    //}

    // Implement Decorator for QueryBuilder?

    public interface IQueryBuilderBase
    {
        string Query { get; set; }
        string Selector { get; set; }
        string From { get; set; }
        string Table { get; set; }
        string Where { get; set; }
        string Column { get; set; }
        string ID { get; set; }
    }

    public class QueryBuilderDecorator : IQueryBuilderBase
    {
        private IQueryBuilderBase QueryBuilder;

        public QueryBuilderDecorator(IQueryBuilderBase query_builder)
        {
            this.QueryBuilder = query_builder;
        }

        public string Query { get { return this.QueryBuilder.Query; } set { this.QueryBuilder.Query = value; } }
        public string Selector { get { return this.QueryBuilder.Selector; } set { this.QueryBuilder.Selector = value; } }
        public string From { get { return this.QueryBuilder.From; } set { this.QueryBuilder.From = value; } }
        public string Table { get { return this.QueryBuilder.Table; } set { this.QueryBuilder.Table = value; } }
        public string Where { get { return this.QueryBuilder.Where; } set { this.QueryBuilder.Where = value; } }
        public string Column { get { return this.QueryBuilder.Column; } set { this.QueryBuilder.Column = value; } }
        public string ID { get { return this.QueryBuilder.ID; } set { this.QueryBuilder.ID = value; } }
    }

    // TODO: Generate queries via the QueryBuilder following the Decorator design pattern

    //public class SelectQueryBuilder : IQueryBuilderBase
    //{
    //    public string Column
    //    {
    //        get
    //        {
    //            return Column;
    //        }

    //        set
    //        {
    //            Column = value;
    //        }
    //    }

    //    public string From
    //    {
    //        get
    //        {
    //            return "FROM";
    //        }
    //    }

    //    public string ID
    //    {
    //        get
    //        {
    //            return ID;
    //        }

    //        set
    //        {
    //            ID = value;
    //        }
    //    }

    //    public string Query
    //    {
    //        get
    //        {
    //            return "SELECT";
    //        }
    //    }

    //    public string Selector
    //    {
    //        get
    //        {
    //            return Selector;
    //        }

    //        set
    //        {
    //            Selector = value;
    //        }
    //    }

    //    public string Table
    //    {
    //        get
    //        {
    //            return Table;
    //        }

    //        set
    //        {
    //            Table = value;
    //        }
    //    }

    //    public string Where
    //    {
    //        get
    //        {
    //            return "WHERE";
    //        }
    //    }

    //    public string GetFullQuery()
    //    {
    //        return $"{Query} {Selector} {From} {Table} {Where} {Column} = {ID}";
    //    }
    //}
}
