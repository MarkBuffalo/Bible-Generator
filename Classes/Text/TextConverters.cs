using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BibleProject.Classes.Text
{
    class TextConverters
    {
        /// <summary>
        /// "The First Book of Daniel", etc. When displaying the book, this string will be formatted for the Web Browser window, and the Form Window.
        /// </summary>
        /// <param name="book">The Bible book</param>
        /// <returns>A string based on the name of the book</returns>
        internal static string GetDisplayString(string book)
        {
            if (book.StartsWith("1"))
            {
                return "The First Book of " + book.Replace("1 ", "");
            }
            if (book.StartsWith("2"))
            {
                return "The Second Book of " + book.Replace("2 ", "");
            }
            if (book.StartsWith("3"))
            {
                return "The Third Book of " + book.Replace("3 ", "");
            }
            else
            {
                return "The Book of " + book;
            }
        }


        /// <summary>
        /// Gets the List of Embedded resources for a particular folder.
        /// </summary>
        /// <param name="internalFolder">Name of the folder you're looking for. Example: BibleProject.BibleFlatFiles.Chinese.TraditionalFiles</param>
        /// <returns>string[] array of all files found</returns>
        internal static string[] GetAllEmbeddedResourcesByFolder(string internalFolder)
        {
            var executingAssembly = Assembly.GetExecutingAssembly();
            string folderName = internalFolder;
            return executingAssembly.GetManifestResourceNames().Where(r => r.StartsWith(folderName)).ToArray();
        }


        /// <summary>
        /// Converts the current string from Big5 encoding to UTF-8
        /// </summary>
        /// <param name="Big5ChineseString">Big5 Chinese String</param>
        /// <returns>UTF-8 Encoded Chinese characters</returns>
        internal static String GetUTF8StringFromBig5String(string Big5ChineseString)
        {
            if (!String.IsNullOrEmpty(Big5ChineseString))
            {
                // The file is encoded using Big5 encoding. Let's convert this to UTF-8 so it can be read easier.
                Encoding big5 = Encoding.GetEncoding("Big5");
                Encoding utf8 = Encoding.GetEncoding("utf-8");

                // First, get the bytes, then convert them.
                byte[] bytesBig5 = big5.GetBytes(Big5ChineseString);
                byte[] bytesUtf8 = Encoding.Convert(big5, utf8, bytesBig5);

                // Now get the characters for the UTF-8 bytes.
                char[] chineseCharactersInUtf8 = new char[utf8.GetCharCount(bytesUtf8, 0, bytesUtf8.Length)];
                utf8.GetChars(bytesUtf8, 0, bytesUtf8.Length, chineseCharactersInUtf8, 0);

                return new string(chineseCharactersInUtf8);
            }
            return "";
        }


        /// <summary>
        /// Gets the full name of the Bible book in Chinese based on a three-character parameter.
        /// </summary>
        /// <param name="book">An assigned-integer of the Bible book</param>
        /// <returns>The full name of the book in Chinese.</returns>
        internal static string GetChineseBookNameFromId(int id)
        {
            switch (id)
            {
                case 0: { return "Genesis"; }
                case 1: { return "Exodus"; }
                case 2: { return "Leviticus"; }
                case 3: { return "Numbers"; }
                case 4: { return "Deuteronomy"; }
                case 5: { return "Joshua"; }
                case 6: { return "Judges"; }
                case 7: { return "Ruth"; }
                case 8: { return "1 Samuel"; }
                case 9: { return "2 Samuel"; }
                case 10: { return "1 Kings"; }
                case 11: { return "2 Kings"; }
                case 12: { return "1 Chronicles"; }
                case 13: { return "2 Chronicles"; }
                case 14: { return "Ezra"; }
                case 15: { return "Nehemiah"; }
                case 16: { return "Esther"; }
                case 17: { return "Job"; }
                case 18: { return "Psalms"; }
                case 19: { return "Proverbs"; }
                case 20: { return "Ecclesiastes"; }
                case 21: { return "Song of Solomon"; }
                case 22: { return "Isaiah"; }
                case 23: { return "Jeremiah"; }
                case 24: { return "Lamentations"; }
                case 25: { return "Ezekiel"; }
                case 26: { return "Daniel"; }
                case 27: { return "Hosea"; }
                case 28: { return "Joel"; }
                case 29: { return "Amos"; }
                case 30: { return "Obadiah"; }
                case 31: { return "Jonah"; }
                case 32: { return "Micah"; }
                case 33: { return "Nahum"; }
                case 34: { return "Habakkuk"; }
                case 35: { return "Zephaniah"; }
                case 36: { return "Haggai"; }
                case 37: { return "Zechariah"; }
                case 38: { return "Malachi"; }
                case 39: { return "Matthew"; }
                case 40: { return "Mark"; }
                case 41: { return "Luke"; }
                case 42: { return "John"; }
                case 43: { return "Acts"; }
                case 44: { return "Romans"; }
                case 45: { return "1 Corinthians"; }
                case 46: { return "2 Corinthians"; }
                case 47: { return "Galatians"; }
                case 48: { return "Ephesians"; }
                case 49: { return "Philippians"; }
                case 50: { return "Colossians"; }
                case 51: { return "1 Thessalonians"; }
                case 52: { return "2 Thessalonians"; }
                case 53: { return "1 Timothy"; }
                case 54: { return "2 Timothy"; }
                case 55: { return "Titus"; }
                case 56: { return "Philemon"; }
                case 57: { return "Hebrews"; }
                case 58: { return "James"; }
                case 59: { return "1 Peter"; }
                case 60: { return "2 Peter"; }
                case 61: { return "1 John"; }
                case 62: { return "2 John"; }
                case 63: { return "3 John"; }
                case 64: { return "Jude"; }
                case 65: { return "Revelation"; }
            }
            return "Unknown";
        }



        /// <summary>
        /// Gets the full name of the Bible book based on a three-character parameter.
        /// </summary>
        /// <param name="book">An assigned-integer of the Bible book</param>
        /// <returns>The full name of the book.</returns>
        internal static string GetFullBookNameFromId(int id)
        {
            switch (id)
            {
                case 0: { return "Genesis"; }
                case 1: { return "Exodus"; }
                case 2: { return "Leviticus"; }
                case 3: { return "Numbers"; }
                case 4: { return "Deuteronomy"; }
                case 5: { return "Joshua"; }
                case 6: { return "Judges"; }
                case 7: { return "Ruth"; }
                case 8: { return "1 Samuel"; }
                case 9: { return "2 Samuel"; }
                case 10: { return "1 Kings"; }
                case 11: { return "2 Kings"; }
                case 12: { return "1 Chronicles"; }
                case 13: { return "2 Chronicles"; }
                case 14: { return "Ezra"; }
                case 15: { return "Nehemiah"; }
                case 16: { return "Esther"; }
                case 17: { return "Job"; }
                case 18: { return "Psalms"; }
                case 19: { return "Proverbs"; }
                case 20: { return "Ecclesiastes"; }
                case 21: { return "Song of Solomon"; }
                case 22: { return "Isaiah"; }
                case 23: { return "Jeremiah"; }
                case 24: { return "Lamentations"; }
                case 25: { return "Ezekiel"; }
                case 26: { return "Daniel"; }
                case 27: { return "Hosea"; }
                case 28: { return "Joel"; }
                case 29: { return "Amos"; }
                case 30: { return "Obadiah"; }
                case 31: { return "Jonah"; }
                case 32: { return "Micah"; }
                case 33: { return "Nahum"; }
                case 34: { return "Habakkuk"; }
                case 35: { return "Zephaniah"; }
                case 36: { return "Haggai"; }
                case 37: { return "Zechariah"; }
                case 38: { return "Malachi"; }
                case 39: { return "Matthew"; }
                case 40: { return "Mark"; }
                case 41: { return "Luke"; }
                case 42: { return "John"; }
                case 43: { return "Acts"; }
                case 44: { return "Romans"; }
                case 45: { return "1 Corinthians"; }
                case 46: { return "2 Corinthians"; }
                case 47: { return "Galatians"; }
                case 48: { return "Ephesians"; }
                case 49: { return "Philippians"; }
                case 50: { return "Colossians"; }
                case 51: { return "1 Thessalonians"; }
                case 52: { return "2 Thessalonians"; }
                case 53: { return "1 Timothy"; }
                case 54: { return "2 Timothy"; }
                case 55: { return "Titus"; }
                case 56: { return "Philemon"; }
                case 57: { return "Hebrews"; }
                case 58: { return "James"; }
                case 59: { return "1 Peter"; }
                case 60: { return "2 Peter"; }
                case 61: { return "1 John"; }
                case 62: { return "2 John"; }
                case 63: { return "3 John"; }
                case 64: { return "Jude"; }
                case 65: { return "Revelation"; }
            }
            return "Unknown";
        }

        /// <summary>
        /// Gets the full name of the Bible book based on a three-character parameter.
        /// </summary>
        /// <param name="book">A three-character abbreviation of the Bible book</param>
        /// <returns>The full name of the book.</returns>
        internal static string GetBookNameFromAbbreviation(string book)
        {
            switch (book.ToLower())
            {
                case "gen": { return "Genesis"; }
                case "exo": { return "Exodus"; }
                case "lev": { return "Leviticus"; }
                case "num": { return "Numbers"; }
                case "deu": { return "Deuteronomy"; }
                case "jos": { return "Joshua"; }
                case "jdg": { return "Judges"; }
                case "rut": { return "Ruth"; }
                case "sa1": { return "1 Samuel"; }
                case "sa2": { return "2 Samuel"; }
                case "kg1": { return "1 Kings"; }
                case "kg2": { return "2 Kings"; }
                case "ch1": { return "1 Chronicles"; }
                case "ch2": { return "2 Chronicles"; }
                case "ezr": { return "Ezra"; }
                case "neh": { return "Nehemiah"; }
                case "est": { return "Esther"; }
                case "job": { return "Job"; }
                case "psa": { return "Psalms"; }
                case "pro": { return "Proverbs"; }
                case "ecc": { return "Ecclesiastes"; }
                case "sol": { return "Song of Solomon"; }
                case "isa": { return "Isaiah"; }
                case "jer": { return "Jeremiah"; }
                case "lam": { return "Lamentations"; }
                case "eze": { return "Ezekiel"; }
                case "dan": { return "Daniel"; }
                case "hos": { return "Hosea"; }
                case "joe": { return "Joel"; }
                case "amo": { return "Amos"; }
                case "oba": { return "Obadiah"; }
                case "jon": { return "Jonah"; }
                case "mic": { return "Micah"; }
                case "nah": { return "Nahum"; }
                case "hab": { return "Habakkuk"; }
                case "zep": { return "Zephaniah"; }
                case "hag": { return "Haggai"; }
                case "zac": { return "Zechariah"; }
                case "mal": { return "Malachi"; }
                case "mat": { return "Matthew"; }
                case "mar": { return "Mark"; }
                case "luk": { return "Luke"; }
                case "joh": { return "John"; }
                case "act": { return "Acts"; }
                case "rom": { return "Romans"; }
                case "co1": { return "1 Corinthians"; }
                case "co2": { return "2 Corinthians"; }
                case "gal": { return "Galatians"; }
                case "eph": { return "Ephesians"; }
                case "phi": { return "Philippians"; }
                case "col": { return "Colossians"; }
                case "th1": { return "1 Thessalonians"; }
                case "th2": { return "2 Thessalonians"; }
                case "ti1": { return "1 Timothy"; }
                case "ti2": { return "2 Timothy"; }
                case "tit": { return "Titus"; }
                case "plm": { return "Philemon"; }
                case "heb": { return "Hebrews"; }
                case "jam": { return "James"; }
                case "pe1": { return "1 Peter"; }
                case "pe2": { return "2 Peter"; }
                case "jo1": { return "1 John"; }
                case "jo2": { return "2 John"; }
                case "jo3": { return "3 John"; }
                case "jde": { return "Jude"; }
                case "rev": { return "Revelation"; }
            }
            return "Unknown - something went wrong";
        }
    }
}
