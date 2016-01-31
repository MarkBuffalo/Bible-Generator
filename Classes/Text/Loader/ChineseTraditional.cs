using BibleProject.Classes.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibleProject.Classes.Text.Loader
{
    class ChineseTraditional : IFlatFile
    {
        List<ChineseFileCollection> cfc = new List<ChineseFileCollection>();

        public void LoadIntoMemory()
        {


            string[] EmbeddedTraditionalChineseFiles = TextConverters.GetAllEmbeddedResourcesByFolder("BibleProject.BibleFlatFiles.Chinese.TraditonalFiles");

            string book;
            int id;

            foreach (string file in EmbeddedTraditionalChineseFiles)
            {
                string testId = Path.GetExtension(file).Replace(".", "");
                id = (Convert.ToInt32(testId) - 1);
                book = TextConverters.GetFullBookNameFromId(id);
                cfc.Add(new ChineseFileCollection(id, book, file));
            }



            // list.OrderBy() is not working. Let's write our own natural order sorting algorithm, especially since every suggestion online appears to be incorrect... glare. May be a PEBKAC issue, but whatever.
            List<ChineseFileCollection> cf = new List<ChineseFileCollection>();

            int current = 0;
            for (int i = 0; i < cfc.Count; i++)
            {
                foreach (var c in cfc)
                {
                    if (i == c.BookId)
                    {
                        cf.Add(new ChineseFileCollection(c.BookId, c.BookName, c.FileName));
                    }
                }
                current++;
            }


            // The string for our new file.
            StringBuilder NewFlatFileString = new StringBuilder();


            cf.Count();

            foreach (var c in cf)
            {
                using (StreamReader r = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(c.FileName), Encoding.GetEncoding("Big5")))
                {
                    string CurrentLine = String.Empty;

                    // Get the Current line and convert it to UTF8
                    while ((CurrentLine = r.ReadLine()) != null)
                    {
                        String Book = TextConverters.GetTraditionalChineseBookNameFromId(c.BookId);
                        int Chapter = Convert.ToInt32(CurrentLine.Split(':')[0]);
                        int Verse = Convert.ToInt32(CurrentLine.Split(':')[1].Split(' ')[0]);
                        String Word = TextConverters.GetUTF8StringFromBig5String(CurrentLine.Split(' ')[1]);

                        MemoryStorage.ChineseTraditional.Add(new BibleCollection(Book, Chapter, Verse, Word));
                    }
                }
            }
            MemoryStorage.FullDataCollection.Add(new FullCollection(MemoryStorage.ChineseTraditional));
        }
    }
}