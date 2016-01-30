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
    class ChineseSimplified : IFlatFile
    {

        // Gen 1:1 Æð³õÉñ´´ÔìÌìµØ¡£
        public void LoadIntoMemory()
        {
            string book, word = String.Empty;
            int chapter, verse = 0;

            using (StreamReader r = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("BibleProject.BibleFlatFiles.Chinese.SimplifiedChinese.txt")))
            {
                string CurrentLine = String.Empty;
                while ((CurrentLine = r.ReadLine()) != null)
                {

                    book = TextConverters.GetSimplifiedChineseBookNameFromId(TextConverters.GetBookIdFromAbbr(CurrentLine.Split(' ')[0]));
                    chapter = Convert.ToInt32(CurrentLine.Split(':')[0].Split(' ')[1]);
                    verse = Convert.ToInt32(CurrentLine.Split(':')[1].Split(' ')[0]);
                    word = CurrentLine.Split(' ')[2];


                    MemoryStorage.EnglishKjv.Add(new BibleCollection(book, chapter, verse, word));
                }
                MemoryStorage.FullDataCollection.Add(new FullCollection(MemoryStorage.EnglishKjv));
            }
        }
    }
}
