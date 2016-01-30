using BibleProject.Classes.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleProject.Classes.Database.Queries
{
    internal class SqlServer
    {
        public static string CheckIfTableExists()
        {
            return "SELECT name FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[@Language]') AND type in (N'U')";
        }

        public static string GetTableCreationString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("IF OBJECT_ID('[dbo].[@Language]', 'U') IS NOT NULL DROP TABLE [dbo].[@Language]; ");
            sb.Append("CREATE TABLE [dbo].[@Language] (");
            sb.Append("    [Id]      INT            IDENTITY (1, 1) NOT NULL,");
            sb.Append("    [Book]    VARCHAR (20)   NOT NULL,");
            sb.Append("    [Chapter] INT	    NOT NULL,");
            sb.Append("    [Verse]   INT	    NOT NULL,");
            sb.Append("    [Word]    VARCHAR (2000) NOT NULL,");
            sb.Append("    PRIMARY KEY CLUSTERED ([Id] ASC)");
            sb.Append(");");
            return sb.ToString();
        }

        public static string GetDataInsertionString()
        {
            return "INSERT INTO [@Language] (Book, Chapter, Verse, Word) VALUES (@Book, @Chapter, @Verse, @Word)";
        }
    }
}
