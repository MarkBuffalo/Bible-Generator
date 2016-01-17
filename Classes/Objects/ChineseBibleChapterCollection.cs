using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleProject.Classes.Objects
{
    class ChineseBibleChapterCollection
    {
        public ChineseBibleChapterCollection(string Book, int Chapter, int Verse, string Word)
        {
            this.Book = Book;
            this.Chapter = Chapter;
            this.Verse = Verse;
            this.Word = Word;
        }
        public string Book;
        public int Chapter;
        public int Verse;
        public string Word;
    }
}
