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
            this.CreateEmployeeTable();
            this.CreateAddressesTable();
        }

        public static void CreateDatabase()
        {
            SQLiteConnection.CreateFile("DefaultDB.sqlite");
        }

        private void CreateEmployeeTable()
        {
            string create_employee_table = "CREATE TABLE IF NOT EXISTS `employees` (`bsn` INTEGER PRIMARY KEY, `first_name` STRING NOT NULL, `last_name` STRING NOT NULL)";

            this.DoSQL(create_employee_table);
        }

        private void CreateAddressesTable()
        {
            string create_addresses_table = "CREATE TABLE IF NOT EXISTS `addresses` (`id` INTEGER PRIMARY KEY AUTOINCREMENT, `name` STRING NOT NULL, `street` STRING NOT NULL)";

            this.DoSQL(create_addresses_table);
        }

        private void DoSQL(string query)
        {
            this.SQLiteConnection.Open();
            this.SQLiteCommand = new SQLiteCommand(query, this.SQLiteConnection);
            this.SQLiteCommand.ExecuteNonQuery();
            this.SQLiteConnection.Close();
        }
    }
}
