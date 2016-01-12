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
            return "SELECT name FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Contents]') AND type in (N'U')";
        }

        public static string GetTableCreationString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("IF OBJECT_ID('[dbo].[Contents]', 'U') IS NOT NULL DROP TABLE [dbo].[Contents]; ");
            sb.Append("CREATE TABLE [dbo].[Contents] (");
            sb.Append("    [Id]      INT            IDENTITY (1, 1) NOT NULL,");
            sb.Append("    [Book]    VARCHAR (20)   NOT NULL,");
            sb.Append("    [Chapter] VARCHAR (20)   NOT NULL,");
            sb.Append("    [Verse]   VARCHAR (20)   NOT NULL,");
            sb.Append("    [Word]    VARCHAR (2000) NOT NULL,");
            sb.Append("    PRIMARY KEY CLUSTERED ([Id] ASC)");
            sb.Append(");");
            return sb.ToString();
        }
        public static string GetDataInsertionString()
        {
            return "INSERT INTO [Contents] (Book, Chapter, Verse, Word) VALUES (@Book, @Chapter, @Verse, @Word)";
        }
    }
}
