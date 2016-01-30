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
        /// Converts the current string from Big5 encoding to UTF-8
        /// </summary>
        /// <param name="Big5ChineseString">Big5 Chinese String</param>
        /// <returns>UTF-8 Encoded Chinese characters</returns>
        internal static String GetUTF8StringFromGB936String(string GB396ChineseString)
        {
            if (!String.IsNullOrEmpty(GB396ChineseString))
            {
                // The file is encoded using Big5 encoding. Let's convert this to UTF-8 so it can be read easier.
                Encoding big5 = Encoding.GetEncoding("gb2312");
                Encoding utf8 = Encoding.GetEncoding("utf-8");

                // First, get the bytes, then convert them.
                byte[] bytesBig5 = big5.GetBytes(GB396ChineseString);
                byte[] bytesUtf8 = Encoding.Convert(big5, utf8, bytesBig5);

                // Now get the characters for the UTF-8 bytes.
                char[] chineseCharactersInUtf8 = new char[utf8.GetCharCount(bytesUtf8, 0, bytesUtf8.Length)];
                utf8.GetChars(bytesUtf8, 0, bytesUtf8.Length, chineseCharactersInUtf8, 0);

                return new string(chineseCharactersInUtf8);
            }
            return "";
        }


        /// <summary>
        /// Gets the full name of the Bible book in Simplified Chinese based on an id parameter.
        /// </summary>
        /// <param name="book">An assigned-integer of the Bible book</param>
        /// <returns>The full name of the book in Chinese.</returns>
        internal static string GetSimplifiedChineseBookNameFromId(int id)
        {
            switch (id)
            {
                case 0: { return "创世记"; }
                case 1: { return "出埃及"; }
                case 2: { return "利未记"; }
                case 3: { return "民数记"; }
                case 4: { return "申命记"; }
                case 5: { return "约书亚记"; }
                case 6: { return "士师记"; }
                case 7: { return "路得记"; }
                case 8: { return "撒母耳记上"; }
                case 9: { return "撒母耳记下"; }
                case 10: { return "列王纪上"; }
                case 11: { return "列王纪下"; }
                case 12: { return "历代志上"; }
                case 13: { return "历代志下"; }
                case 14: { return "以斯拉记"; }
                case 15: { return "尼希米记"; }
                case 16: { return "以斯帖记"; }
                case 17: { return "约伯记"; }
                case 18: { return "诗篇"; }
                case 19: { return "箴言"; }
                case 20: { return "传道书"; }
                case 21: { return "雅歌"; }
                case 22: { return "以赛亚书"; }
                case 23: { return "耶利米书"; }
                case 24: { return "耶利米哀歌"; }
                case 25: { return "以西结书"; }
                case 26: { return "但以理书"; }
                case 27: { return "何西阿书"; }
                case 28: { return "约珥书"; }
                case 29: { return "阿摩司书"; }
                case 30: { return "俄巴底亚书"; }
                case 31: { return "约拿书"; }
                case 32: { return "弥迦书"; }
                case 33: { return "那鸿书"; }
                case 34: { return "哈巴谷书"; }
                case 35: { return "西番雅书"; }
                case 36: { return "哈该书"; }
                case 37: { return "撒迦利亚书"; }
                case 38: { return "玛拉基书"; }
                case 39: { return "马太福音"; }
                case 40: { return "马可福音"; }
                case 41: { return "路加福音"; }
                case 42: { return "约翰福音"; }
                case 43: { return "使徒行传"; }
                case 44: { return "罗马书"; }
                case 45: { return "哥林多前书"; }
                case 46: { return "哥林多后书"; }
                case 47: { return "加拉太书"; }
                case 48: { return "以弗所书"; }
                case 49: { return "腓立比书"; }
                case 50: { return "歌罗西书"; }
                case 51: { return "帖撒罗尼迦前书"; }
                case 52: { return "帖撒罗尼迦后书"; }
                case 53: { return "提摩太前书"; }
                case 54: { return "提摩太后书"; }
                case 55: { return "提多书"; }
                case 56: { return "腓利门书"; }
                case 57: { return "希伯来书"; }
                case 58: { return "雅各书"; }
                case 59: { return "彼得前书"; }
                case 60: { return "彼得后书"; }
                case 61: { return "约翰一书"; }
                case 62: { return "约翰二书"; }
                case 63: { return "约翰三书"; }
                case 64: { return "犹大书"; }
                case 65: { return "启示录"; }
            }
            return "Unknown";
        }


        internal static string GetTraditionalChineseBookNameFromId(int id)
        {
            switch (id)
            {
                case 0: { return "創世記"; }
                case 1: { return "出埃及"; }
                case 2: { return "利未記"; }
                case 3: { return "民數記"; }
                case 4: { return "申命記"; }
                case 5: { return "約書亞記"; }
                case 6: { return "士師記"; }
                case 7: { return "路得記"; }
                case 8: { return "撒母耳記上"; }
                case 9: { return "撒母耳記下"; }
                case 10: { return "列王紀上"; }
                case 11: { return "列王紀下"; }
                case 12: { return "歷代誌上"; }
                case 13: { return "歷代誌下"; }
                case 14: { return "以斯拉記"; }
                case 15: { return "尼希米記"; }
                case 16: { return "以斯帖記"; }
                case 17: { return "約伯記"; }
                case 18: { return "詩篇"; }
                case 19: { return "箴言"; }
                case 20: { return "傳道書"; }
                case 21: { return "雅歌"; }
                case 22: { return "以賽亞書"; }
                case 23: { return "耶利米書"; }
                case 24: { return "耶利米哀歌"; }
                case 25: { return "以西結書"; }
                case 26: { return "但以理書"; }
                case 27: { return "何西阿書"; }
                case 28: { return "約珥書"; }
                case 29: { return "阿摩司書"; }
                case 30: { return "俄巴底亞書"; }
                case 31: { return "約拿書"; }
                case 32: { return "彌迦書"; }
                case 33: { return "那鴻書"; }
                case 34: { return "哈巴谷書"; }
                case 35: { return "西番雅書"; }
                case 36: { return "哈該書"; }
                case 37: { return "撒迦利亞書"; }
                case 38: { return "瑪拉基書"; }
                case 39: { return "馬太福音"; }
                case 40: { return "馬可福音"; }
                case 41: { return "路加福音"; }
                case 42: { return "約翰福音"; }
                case 43: { return "使徒行傳"; }
                case 44: { return "羅馬書"; }
                case 45: { return "哥林多前書"; }
                case 46: { return "哥林多後書"; }
                case 47: { return "加拉太書"; }
                case 48: { return "以弗所書"; }
                case 49: { return "腓立比書"; }
                case 50: { return "歌羅西書"; }
                case 51: { return "帖撒羅尼迦前書"; }
                case 52: { return "帖撒羅尼迦後書"; }
                case 53: { return "提摩太前書"; }
                case 54: { return "提摩太后書"; }
                case 55: { return "提多書"; }
                case 56: { return "腓利門書"; }
                case 57: { return "希伯來書"; }
                case 58: { return "雅各書"; }
                case 59: { return "彼得前書"; }
                case 60: { return "彼得後書"; }
                case 61: { return "約翰一書"; }
                case 62: { return "約翰二書"; }
                case 63: { return "約翰三書"; }
                case 64: { return "猶大書"; }
                case 65: { return "啟示錄"; }
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
        /// Gets the Book ID from abbreviation for language-neutral translation.
        /// </summary>
        /// <param name="book">Book abbreviation in English</param>
        /// <returns>Book number.</returns>
        internal static int GetBookIdFromAbbr(string book)
        {
            switch (book.ToLower())
            {
                case "gen": { return 0; }
                case "exo": { return 1; }
                case "lev": { return 2; }
                case "num": { return 3; }
                case "deu": { return 4; }
                case "jos": { return 5; }
                case "jdg": { return 6; }
                case "rut": { return 7; }
                case "sa1": { return 8; }
                case "sa2": { return 9; }
                case "kg1": { return 10; }
                case "kg2": { return 11; }
                case "ch1": { return 12; }
                case "ch2": { return 13; }
                case "ezr": { return 14; }
                case "neh": { return 15; }
                case "est": { return 16; }
                case "job": { return 17; }
                case "psa": { return 18; }
                case "pro": { return 19; }
                case "ecc": { return 20; }
                case "sol": { return 21; }
                case "isa": { return 22; }
                case "jer": { return 23; }
                case "lam": { return 24; }
                case "eze": { return 25; }
                case "dan": { return 26; }
                case "hos": { return 27; }
                case "joe": { return 28; }
                case "amo": { return 29; }
                case "oba": { return 30; }
                case "jon": { return 31; }
                case "mic": { return 32; }
                case "nah": { return 33; }
                case "hab": { return 34; }
                case "zep": { return 35; }
                case "hag": { return 36; }
                case "zac": { return 37; }
                case "mal": { return 38; }
                case "mat": { return 39; }
                case "mar": { return 40; }
                case "luk": { return 41; }
                case "joh": { return 42; }
                case "act": { return 43; }
                case "rom": { return 44; }
                case "co1": { return 45; }
                case "co2": { return 46; }
                case "gal": { return 47; }
                case "eph": { return 48; }
                case "phi": { return 49; }
                case "col": { return 50; }
                case "th1": { return 51; }
                case "th2": { return 52; }
                case "ti1": { return 53; }
                case "ti2": { return 54; }
                case "tit": { return 55; }
                case "plm": { return 56; }
                case "heb": { return 57; }
                case "jam": { return 58; }
                case "pe1": { return 59; }
                case "pe2": { return 60; }
                case "jo1": { return 61; }
                case "jo2": { return 62; }
                case "jo3": { return 63; }
                case "jde": { return 64; }
                case "rev": { return 65; }
                default: {  return 700; } // Failure
            }
        }




        /// <summary>
        /// Gets the full name of the Bible book based on a three-character parameter.
        /// </summary>
        /// <param name="book">A three-character abbreviation of the Bible book</param>
        /// <returns>The full name of the book.</returns>
        internal static string GetEnglishBookNameFromAbbreviation(string book)
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
