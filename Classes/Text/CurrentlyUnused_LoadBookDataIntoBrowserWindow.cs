using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleProject.Classes.Text
{
    class CurrentlyUnused_LoadBookDataIntoBrowserWindow
    {
        /// <summary>
        /// Loads the data for that particular book into the Web Browser window.
        /// </summary>
        /// <param name="id">Book's ID, as listed in the ComboBox (using the ComboBoxExtension class).</param>
        /// <returns>All chapters and verses for that particular Book.</returns>
       /* internal string LoadBookData(int id)
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
        }*/
    }
}
