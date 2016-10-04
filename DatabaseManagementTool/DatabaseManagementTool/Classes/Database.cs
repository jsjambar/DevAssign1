using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using DatabaseManagementTool.Models;

namespace DatabaseManagementTool.Classes
{
    class Database
    {
        SQLiteConnection SQLiteConnection = new SQLiteConnection($"Data Source=DefaultDB.sqlite;Version=3;");
        SQLiteCommand SQLiteCommand;

        public Database()
        {
            this.CreateEmployeesTable();
            this.CreateAddressesTable();
            this.CreateCountriesTable();
            this.CreatePostalCodesTable();
            this.CreateRolesTable();
            this.CreateProjectsTable();
        }

        public static void CreateDatabase()
        {
            SQLiteConnection.CreateFile("DefaultDB.sqlite");
        }

        private void CreateEmployeesTable()
        {
            string create_employee_table = "CREATE TABLE IF NOT EXISTS `employees` (`bsn` INTEGER PRIMARY KEY, `first_name` STRING NOT NULL, `last_name` STRING NOT NULL, `address` STRING NOT NULL, `education` STRING NOT NULL, `job` STRING NOT NULL, `boolean_deleted` BOOLEAN not null default 0)";

            this.Query(create_employee_table);
        }

        private void CreateAddressesTable()
        {
            string create_addresses_table = "CREATE TABLE IF NOT EXISTS `addresses` (`id` INTEGER PRIMARY KEY AUTOINCREMENT, `name` STRING NOT NULL, `street` STRING NOT NULL)";

            this.Query(create_addresses_table);
        }

        private void CreateRolesTable()
        {
            string create_roles_table = "CREATE TABLE IF NOT EXISTS `roles` (`id` INTEGER PRIMARY KEY AUTOINCREMENT, `name` STRING NOT NULL)";
            this.Query(create_roles_table);
        }

        private void CreateCountriesTable()
        {
            string create_country_table = "CREATE TABLE IF NOT EXISTS `countries` (`id` INTEGER PRIMARY KEY AUTOINCREMENT, `name` STRING NOT NULL)";
            this.Query(create_country_table);
        }

        private void CreatePostalCodesTable()
        {
            string create_postal_codes = "CREATE TABLE IF NOT EXISTS `postal_codes` (`id` INTEGER PRIMARY KEY AUTOINCREMENT, `code` STRING NOT NULL)";
            this.Query(create_postal_codes);
        }

        private void CreateProjectsTable()
        {
            string create_projects_table = "CREATE TABLE IF NOT EXISTS `projects` (`id` INTEGER PRIMARY KEY AUTOINCREMENT, `name` STRING NOT NULL, `location` STRING NOT NULL, `budget` INT NOT NULL, `hours` INT NOT NULL, `boolean_deleted` BOOLEAN not null default 0)";
            this.Query(create_projects_table);
        }

        public void DoQuery(string query)
        {
            this.Query(query);
        }

        private void Query(string query)
        {
            this.SQLiteConnection.Open();
            this.SQLiteCommand = new SQLiteCommand(query, this.SQLiteConnection);
            this.SQLiteCommand.ExecuteNonQuery();
            this.SQLiteConnection.Close();
        }

        // Different models have different properties, need to resolve this
        public static string Select(string select_query)
        {
            SQLiteConnection sqlite_connection = new SQLiteConnection($"Data Source=DefaultDB.sqlite;Version=3;");
            sqlite_connection.Open();
            SQLiteCommand sqlite_command = new SQLiteCommand(select_query, sqlite_connection);
            SQLiteDataReader sql_data_reader = sqlite_command.ExecuteReader();
            string table_name = "";

            while (sql_data_reader.Read())
            {
                table_name = sql_data_reader.GetTableName(0);
            }

            return table_name;

            sqlite_connection.Close();
        }

        public List<Employee> employeeQuery (string sQuery)
        {
            SQLiteConnection sqlite_connection = new SQLiteConnection($"Data Source=DefaultDB.sqlite;Version=3;");
            sqlite_connection.Open();

            List<Employee> values = new List<Employee>();

            SQLiteCommand command = new SQLiteCommand(sQuery, sqlite_connection);
            SQLiteDataReader result = command.ExecuteReader();

            while (result.Read())
            {
                values.Add(new Employee { BSN = Convert.ToInt32(result["bsn"]), Name = result["first_name"].ToString(), Surname = result["last_name"].ToString(), Address = result["address"].ToString(), Education = result["education"].ToString(), Job = result["job"].ToString() });
            }

            return values;
        }

        public List<Project> projectQuery (string sQuery)
        {
            SQLiteConnection sqlite_connection = new SQLiteConnection($"Data Source=DefaultDB.sqlite;Version=3;");
            sqlite_connection.Open();

            List<Project> values = new List<Project>();

            SQLiteCommand command = new SQLiteCommand(sQuery, sqlite_connection);
            SQLiteDataReader result = command.ExecuteReader();
            while (result.Read())
            {
                values.Add(new Project { Id = Convert.ToInt32(result["id"]), Name = result["name"].ToString(), Location = result["location"].ToString(), Budget = Convert.ToInt32(result["budget"]), Hours = Convert.ToInt32(result["hours"]) });
            }

            return values;
        }
    }
}
