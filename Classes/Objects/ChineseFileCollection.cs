using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleProject.Classes.Objects
{
    class ChineseFileCollection
    {
        public ChineseFileCollection(int BookId, string BookName, string FileName)
        {
            this.BookId = BookId;
            this.BookName = BookName;
            this.FileName = FileName;
        }
        public int BookId;
        public string BookName;
        public string FileName;
    }
}
