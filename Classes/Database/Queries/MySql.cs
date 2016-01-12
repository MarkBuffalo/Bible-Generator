using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleProject.Classes.Database.Queries
{
    class MySql
    {

        public static string GetTableCreationString()
        {
            return "USE biblebase; CREATE TABLE Contents (Id INT(6) AUTO_INCREMENT PRIMARY KEY, Book VARCHAR(25) NOT NULL, Chapter VARCHAR(25) NOT NULL, Verse VARCHAR(25),Word VARCHAR(2000));";
        }

        public static string GetDataInsertionString()
        {
            return "INSERT INTO Contents (Book, Chapter, Verse, Word) VALUES (@Book, @Chapter, @Verse, @Word)";
        }

        public static string CheckIfTableExists()
        {
            return "SHOW TABLES LIKE 'Contents'";
        }
    }
}
