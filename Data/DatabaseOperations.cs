using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace Movie_Library.Data
{
    public static class DatabaseOperations
    {
        public static void CreateDatabase()
        {
            if (!File.Exists("MovieLibrary.sqlite"))
            {
                SQLiteConnection.CreateFile("MovieLibrary.sqlite");
            }
        }
    }
}
