using DatabaseManagementTool.Classes;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagementTool.Models
{
    class Project : ORM
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Budget { get; set; }
        public int AllocatedHours { get; set; }
        public int CountryID { get; set; }
        public int AddressID { get; set; }
        public Country Country { get; set; }
        public Address Address { get; set; }

        Database Database = new Database();

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
            Project insertable_project = new Project { Name = Name, Budget = Budget, AllocatedHours = AllocatedHours };
            string create_project = $"INSERT INTO `projects` (`name`, `budget`, `hours`) VALUES ('{insertable_project.Name}', '{insertable_project.Budget}', '{insertable_project.AllocatedHours}')";
            this.Database.DoQuery(create_project);
        }

        public List<object> FindAll()
        {
            SQLiteConnection sqlite_connection = new SQLiteConnection($"Data Source=DefaultDB.sqlite;Version=3;");
            sqlite_connection.Open();
            SQLiteCommand sqlite_command = new SQLiteCommand("SELECT * FROM `projects` ORDER BY `name`", sqlite_connection);
            SQLiteDataReader sql_data_reader = sqlite_command.ExecuteReader();
            List<object> project_list = new List<object>();

            while (sql_data_reader.Read())
            {
                project_list.Add(new Project { ID = sql_data_reader.GetInt32(0), Name = sql_data_reader.GetString(1), Budget = sql_data_reader.GetInt32(3), AllocatedHours = sql_data_reader.GetInt32(4) });
            }

            sqlite_connection.Close();

            return project_list;
        }

        public void Update(object model)
        {
            Project updated_project = new Project { ID = ID, Name = Name, Budget = Budget, AllocatedHours = AllocatedHours };
            string update_country = $"UPDATE `projects` SET `name` = '{updated_project.Name}', `budget` = '{updated_project.Budget}', `hours` = '{updated_project.AllocatedHours}' WHERE `id` = {updated_project.ID}";
            this.Database.DoQuery(update_country);
        }

        public object FindLast()
        {
            throw new NotImplementedException();
        }
    }
}
