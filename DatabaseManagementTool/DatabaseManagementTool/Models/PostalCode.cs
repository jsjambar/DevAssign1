using DatabaseManagementTool.Classes;
using DatabaseManagementTool.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagementTool
{
    public class PostalCode : ORM
    {
        public int ID { get; set; }
        public string Code { get; set; }

        public string City { get; set; }

        Database database = new Database();

        public object Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(object model)
        {
            PostalCode insertable_postal_code = new PostalCode { Code = Code, City = City};
            string create_postal_code = $"INSERT INTO `postal_codes` (`code`, `city`) VALUES ('{insertable_postal_code.Code}', '{insertable_postal_code.City}')";
            this.database.DoQuery(create_postal_code);
        }

        public void Update(object model)
        {
            PostalCode updated_postal_code = new PostalCode { ID = ID, Code = Code , City = City};
            string update_postal_code = $"UPDATE `postal_codes` SET `code` = '{updated_postal_code.Code}', `city` = '{updated_postal_code.City}' WHERE `id` = {updated_postal_code.ID}";
            this.database.DoQuery(update_postal_code);
        }

        public object FindLast()
        {
            throw new NotImplementedException();
        }

        public List<object> FindAll()
        {
            SQLiteConnection sqlite_connection = new SQLiteConnection($"Data Source=DefaultDB.sqlite;Version=3;");
            sqlite_connection.Open();
            SQLiteCommand sqlite_command = new SQLiteCommand("SELECT * FROM `postal_codes` ORDER BY `code`", sqlite_connection);
            SQLiteDataReader sql_data_reader = sqlite_command.ExecuteReader();
            List<object> postal_code_list = new List<object>();

            while (sql_data_reader.Read())
            {
                postal_code_list.Add(new PostalCode { ID = sql_data_reader.GetInt32(0), Code = sql_data_reader.GetString(1), City = sql_data_reader.GetString(2) });
            }

            sqlite_connection.Close();

            return postal_code_list;
        }
    }
}
