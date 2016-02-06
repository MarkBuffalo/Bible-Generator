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

                    book = TextConverters.GetSimplifiedChineseBookNameFromId(TextConverters.GetBookIdFromAbbreviation(CurrentLine.Split('|')[0]));
                    chapter = Convert.ToInt32(CurrentLine.Split(' ')[0].Split('|')[1]);
                    verse = Convert.ToInt32(CurrentLine.Split(' ')[0].Split('|')[2]);
                    try
                    {
                        word = CurrentLine.Split(' ')[1];
                    }
                    // There's no line there because the verse has been removed to make sense in this Language. 
                    // The removed verse is still intact; it's only combined with the previous verse.
                    catch (IndexOutOfRangeException)
                    {
                        word = " ";
                    }

                    MemoryStorage.ChineseSimplified.Add(new BibleCollection(book, chapter, verse, word));
                }
                MemoryStorage.FullDataCollection.Add(new FullCollection(MemoryStorage.ChineseSimplified));
            }
        }
    }
}
