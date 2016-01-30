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
            return "USE biblebase; CREATE TABLE @Language (Id INT(6) AUTO_INCREMENT PRIMARY KEY, Book VARCHAR(20) NOT NULL, Chapter SMALLINT NOT NULL, Verse SMALLINT NOT NULL, Word VARCHAR(2000) NOT NULL);";
        }

        public static string GetDataInsertionString()
        {
            return "INSERT INTO @Language (Book, Chapter, Verse, Word) VALUES(@Book, @Chapter, @Verse, @Word)";
        }

        public static string CheckIfTableExists()
        {
            return "SHOW TABLES LIKE '@Language'";
        }
    }
}
