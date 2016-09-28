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
        public List<Country> CountryList = new List<Country>();

        Database database = new Database();

        public void Create(object model)
        {
            Country insertable_country = new Country() { Name = Name };
            string create_country = $"INSERT INTO `countries` (`name`) VALUES ('{insertable_country.Name}')"; ;
            this.database.DoQuery(create_country);
        }

        public void Delete(int id)
        {
            string delete_country = $"DELETE * FROM `countries` WHERE `id` = {id}";
            this.database.DoQuery(delete_country);
        }

        public object Find(int id)
        {
            string find_country = $"SELECT * FROM `countries` WHERE `id` = {id}";
            Database.Select(find_country);

            Country found_country = new Country { };
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
            Country updated_country = new Country { Name = Name };
            string update_country = $"UPDATE `countries` SET `name` = '{updated_country.Name}' WHERE `id` = {updated_country.ID}";
            this.database.DoQuery(update_country);
        }
    }
}
