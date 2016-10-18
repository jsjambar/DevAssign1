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
    public class Address : ORM    {
        public int ID { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        Database database = new Database();

        public void Create(object model)
        {
            Address insertable_address = new Address {Street = Street, Number = Number };
            string create_address = $"INSERT INTO `addresses` (`name`, `street`) VALUES ('{insertable_address.Street}', '{insertable_address.Number}')";
            this.database.DoQuery(create_address);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public object Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<object> FindAll()
        {
            SQLiteConnection sqlite_connection = new SQLiteConnection($"Data Source=DefaultDB.sqlite;Version=3;");
            sqlite_connection.Open();
            SQLiteCommand sqlite_command = new SQLiteCommand("SELECT * FROM `addresses` ORDER BY `street`", sqlite_connection);
            SQLiteDataReader sql_data_reader = sqlite_command.ExecuteReader();
            List<object> address_list = new List<object>();

            while (sql_data_reader.Read())
            {
                address_list.Add(new Address { ID = sql_data_reader.GetInt32(0), Street = sql_data_reader.GetString(1), Number = sql_data_reader.GetString(2) });
            }

            sqlite_connection.Close();

            return address_list;
        }

        public object FindLast()
        {
            throw new NotImplementedException();
        }

        public void Update(object model)
        {
            throw new NotImplementedException();
        }
    }
}
