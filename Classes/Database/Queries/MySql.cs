using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleProject.Classes.Database.Queries
{
    class MySql
    {

        // This is all local. If you want to SQL inject yourself, be my guest. Neither MysQL nor SQL Server allow table names to be parameters. Only values.

        public static string GetTableCreationString(QueryLanguage ql)
        {
            return "USE biblebase; CREATE TABLE " + ql.ToString() + " (Id INT(6) AUTO_INCREMENT PRIMARY KEY, Book VARCHAR(20) NOT NULL, Chapter SMALLINT NOT NULL, Verse SMALLINT NOT NULL, Word VARCHAR(2000) NOT NULL);";
        }

        public static string GetDataInsertionString(QueryLanguage ql)
        {
            return "INSERT INTO " + ql.ToString() + " (Book, Chapter, Verse, Word) VALUES(@Book, @Chapter, @Verse, @Word)";
        }

        public static string CheckIfTableExists(QueryLanguage ql)
        {
            return "SHOW TABLES LIKE '" + ql.ToString() + "'";
        }
    }
}
