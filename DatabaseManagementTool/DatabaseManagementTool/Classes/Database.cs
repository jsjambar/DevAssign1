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

        //public static void CreateDatabase(string file_path)
        //{
        //    SQLiteConnection.CreateFile($"@{file_path}");
        //}

    }
}
