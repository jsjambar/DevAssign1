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
    public class Role : ORM
    {
        public int ID { get; set; }
        public string Name { get; set; }

        Database database = new Database();

        public void Create(object model)
        {
            Role role = new Role { ID = ID, Name = Name };
            string create_role = $"INSERT INTO `roles` (`name`) VALUES ('{role.Name}')";
            this.database.DoQuery(create_role);
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
            SQLiteCommand sqlite_command = new SQLiteCommand("SELECT * FROM `roles` ORDER BY `name`", sqlite_connection);
            SQLiteDataReader sql_data_reader = sqlite_command.ExecuteReader();
            List<object> role_list = new List<object>();

            while (sql_data_reader.Read())
            {
                role_list.Add(new Role { ID = sql_data_reader.GetInt32(0), Name = sql_data_reader.GetString(1) });
            }

            sqlite_connection.Close();

            return role_list;
        }

        public object FindLast()
        {
            throw new NotImplementedException();
        }

        public void Update(object model)
        {
            Role updated_role = new Role { ID = ID, Name = Name };
            string update_role = $"UPDATE `roles` SET `name` = '{updated_role.Name}' WHERE `id` = {updated_role.ID}";
            this.database.DoQuery(update_role);
        }
    }
}
