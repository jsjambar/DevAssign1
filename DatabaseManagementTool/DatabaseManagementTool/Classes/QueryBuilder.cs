using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagementTool.Classes
{
    // Might be implemented in version 2

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

        public virtual string Query { get { return this.QueryBuilder.Query; } set { this.QueryBuilder.Query = value; } }
        public virtual string Selector { get { return this.QueryBuilder.Selector; } set { this.QueryBuilder.Selector = value; } }
        public virtual string From { get { return this.QueryBuilder.From; } set { this.QueryBuilder.From = value; } }
        public virtual string Table { get { return this.QueryBuilder.Table; } set { this.QueryBuilder.Table = value; } }
        public virtual string Where { get { return this.QueryBuilder.Where; } set { this.QueryBuilder.Where = value; } }
        public virtual string Column { get { return this.QueryBuilder.Column; } set { this.QueryBuilder.Column = value; } }
        public virtual string ID { get { return this.QueryBuilder.ID; } set { this.QueryBuilder.ID = value; } }
    }

    public class SelectQueryBuilder : QueryBuilderDecorator
    {
        public SelectQueryBuilder(IQueryBuilderBase query_builder_base) : base(query_builder_base)
        {
        }

        public override string Query
        {
            get
            {
                return "SELECT";
            }
        }

        public override string Selector
        {
            get
            {
                return "*";
            }
        }

        public override string From
        {
            get
            {
                return "FROM";
            }
        }
    }
}
