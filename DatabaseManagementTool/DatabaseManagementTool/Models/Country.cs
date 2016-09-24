using DatabaseManagementTool.Classes;
using DatabaseManagementTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagementTool
{
    public class Country : ORM
    {
        public int ID { get; set; }
        public string Name { get; set; }

        Database database = new Database();

        public void Create(object model)
        {
            Country insertable_country = new Country() { Name = Name };
            string create_country = $"INSERT INTO `countries` (`name`) VALUES (`{insertable_country.Name}`)"; ;
            database.AddCountry(create_country);
        }

        public void Delete(int id)
        {
        }

        public object Find(int id)
        {
            return null;
        }

        public object FindAll()
        {
            return null;
        }

        public object FindLast()
        {
            return null;
        }

        public void Update(object model)
        {
        }
    }
}
