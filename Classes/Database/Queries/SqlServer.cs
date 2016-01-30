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

        // This is all local. If you want to SQL inject yourself, be my guest. Neither MysQL nor SQL Server allow table names to be parameters. Only values.
        public static string CheckIfTableExists(QueryLanguage ql)
        {
            return "SELECT name FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[" + ql.ToString() + "]') AND type in (N'U')";
        }

        public static string GetTableCreationString(QueryLanguage ql)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("IF OBJECT_ID('[dbo].[" + ql.ToString() + "]', 'U') IS NOT NULL DROP TABLE [dbo].[" + ql.ToString() + "]; ");
            sb.Append("CREATE TABLE [dbo].[" + ql.ToString() + "] (");
            sb.Append("    [Id]      INT            IDENTITY (1, 1) NOT NULL,");
            sb.Append("    [Book]    VARCHAR (20)   NOT NULL,");
            sb.Append("    [Chapter] INT	    NOT NULL,");
            sb.Append("    [Verse]   INT	    NOT NULL,");
            sb.Append("    [Word]    VARCHAR (2000) NOT NULL,");
            sb.Append("    PRIMARY KEY CLUSTERED ([Id] ASC)");
            sb.Append(");");
            return sb.ToString();
        }

        public static string GetDataInsertionString(QueryLanguage ql)
        {
            return "INSERT INTO [" + ql.ToString() + "] (Book, Chapter, Verse, Word) VALUES (@Book, @Chapter, @Verse, @Word)";
        }
    }
}
