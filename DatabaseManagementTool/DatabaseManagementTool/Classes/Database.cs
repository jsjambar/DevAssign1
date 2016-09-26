using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

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
        }

        public static void CreateDatabase()
        {
            SQLiteConnection.CreateFile("DefaultDB.sqlite");
        }

        private void CreateEmployeesTable()
        {
            string create_employee_table = "CREATE TABLE IF NOT EXISTS `employees` (`bsn` INTEGER PRIMARY KEY, `first_name` STRING NOT NULL, `last_name` STRING NOT NULL)";

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

        public void AddCountry(string query)
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
        public static void Select(string select_query, List<object> model)
        {
            SQLiteConnection sqlite_connection = new SQLiteConnection($"Data Source=DefaultDB.sqlite;Version=3;");
            sqlite_connection.Open();
            SQLiteCommand sqlite_command = new SQLiteCommand(select_query, sqlite_connection);
            SQLiteDataReader sql_data_reader = sqlite_command.ExecuteReader();

            while (sql_data_reader.Read())
            {
            }
        }
    }
}
