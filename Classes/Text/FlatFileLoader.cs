using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using BibleProject.Classes;
using BibleProject.Classes.Text;
using System.Data.Sql;
using BibleProject.Classes.Objects;

namespace BibleProject.Classes.Text
{
    class FlatFileLoader
    {
        /// <summary>
        /// Loads the data for that particular book into the Web Browser window.
        /// </summary>
        /// <param name="id">Book's ID, as listed in the ComboBox (using the ComboBoxExtension class).</param>
        /// <returns>All chapters and verses for that particular Book.</returns>
        internal string LoadBookData(int id)
        {
            string FullBookName = TextConverters.GetFullBookNameFromId(id);

            string html = String.Empty;
            html += @"
                        <html>
                            <head>
                                <title></title>
                                <style>
                                    body   
                                    {
                                        font-family: tahoma, kalimati, sans-serif;
                                        font-size: 10pt;
                                    }
                                    li strong
                                    {
                                        color: #000099;
                                    }
                                </style>
                            </head>
                            <body>
                                <h1 style='text-align: center;'>" + TextConverters.GetDisplayString(FullBookName) + @"</h1>";

            int lastChapter = 0;
            int currentChapter = 0;
            bool nextChapter = false;

            foreach (var data in MemoryStorage.FullDataCollection[0].BibleCollection)
            {
                if (data.CurrentBook == id)
                {
                    currentChapter = data.Chapter;
                    if (currentChapter > 0 && nextChapter)
                    {
                        html += "<h1>Chapter " + currentChapter + "</h1></br/><ul>" + Environment.NewLine;
                    }
                    else if (!nextChapter && lastChapter != currentChapter)
                    {
                        html += "</ul><br/><h1>Chapter " + currentChapter + "</h1></br/><ul>" + Environment.NewLine;
                    }
                    html += "<li><strong>" + data.Chapter + ":" + data.Verse + "</strong> — " + data.Word + "</li>" + Environment.NewLine;
                    lastChapter = currentChapter;
                }
            }
            html += "</body></html>";
            return html;
        }

        /// <summary>
        /// Loads the entire KJV Bible into memory.
        /// </summary>
        internal void LoadBibleIntoMemory()
        {
            int currentBook = 0;
            string book, word, lastBook = string.Empty;
            int chapter, verse = 0;

            using (StreamReader r = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("BibleProject.BibleFormatFiles.kjvdat.txt")))
            {
                string CurrentLine = String.Empty;
                while ((CurrentLine = r.ReadLine()) != null)
                {

                    book = CurrentLine.Split('|')[0];
                    chapter = Convert.ToInt32(CurrentLine.Split('|')[1]);
                    verse = Convert.ToInt32(CurrentLine.Split('|')[2]);
                    word = CurrentLine.Split('|')[3].Split('~')[0];

                    if (!String.IsNullOrEmpty(lastBook) && lastBook != book) // lastBook was set, but it's not the same as the current book.
                    {
                        currentBook++;
                        MemoryStorage.BookList.Add(new BookCollection(currentBook, TextConverters.GetBookNameFromAbbreviation(book)));
                    }
                    else if (String.IsNullOrEmpty(lastBook)) // Last book was not set. Insert book name.
                    {
                        MemoryStorage.BookList.Add(new BookCollection(currentBook, TextConverters.GetBookNameFromAbbreviation(book)));
                    }
                    MemoryStorage.Bible.Add(new BibleCollection(currentBook, chapter, verse, word));
                    lastBook = book;
                }
                MemoryStorage.FullDataCollection.Add(new FullCollection(MemoryStorage.Bible, MemoryStorage.BookList));
            }
        }
    }
}