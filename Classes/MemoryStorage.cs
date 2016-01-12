using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibleProject.Classes.Objects;
using BibleProject.Classes.Text;

namespace BibleProject.Classes
{
    /// <summary>
    /// A collection of variables to use in various places.
    /// </summary>
    class MemoryStorage
    {
        public static List<BibleCollection> Bible { get; set; }
        public static List<BookCollection> BookList { get; set; }
        public static List<FullCollection> FullDataCollection { get; set; }

        public static FlatFileLoader BibleLoaderClass { get; set; }

        public static int FoundBook { get; set; }
        public static int FoundChapter { get; set; }
        public static int FoundVerse { get; set; }
        public static int FoundEndVerse { get; set; }
        public static int FoundEndChapter { get; set; }

        public static string FoundWordQuery { get; set; }
    }
}
