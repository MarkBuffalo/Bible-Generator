using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BibleProject.Classes.Text.Loader
{
    class EnglishKjv : IFlatFile
    {
        public void LoadIntoMemory()
        {
            string book, word = String.Empty;
            int chapter, verse = 0;

            using (StreamReader r = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("BibleProject.BibleFlatFiles.English.kjvdat.txt")))
            {
                string CurrentLine = String.Empty;
                while ((CurrentLine = r.ReadLine()) != null)
                {

                    book = CurrentLine.Split('|')[0];
                    chapter = Convert.ToInt32(CurrentLine.Split('|')[1]);
                    verse = Convert.ToInt32(CurrentLine.Split('|')[2]);
                    word = CurrentLine.Split('|')[3].Split('~')[0];


                    MemoryStorage.EnglishKjv.Add(new BibleCollection(TextConverters.GetEnglishBookNameFromAbbreviation(book), chapter, verse, word));
                }
                MemoryStorage.FullDataCollection.Add(new FullCollection(MemoryStorage.EnglishKjv));
            }
        }
    }
}
