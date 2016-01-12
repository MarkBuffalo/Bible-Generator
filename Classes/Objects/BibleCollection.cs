/// <summary>
/// The data from the Bible. Chapter, Verse, Word of God. It also includes a CurrentBook integer, which is used to link to the Book Collection. This saves memory.
/// </summary>
public class BibleCollection
{
    public BibleCollection(int _CurrentBook, int _Chapter, int _Verse, string _Word)
    {
        CurrentBook = _CurrentBook;
        Chapter = _Chapter;
        Verse = _Verse;
        Word = _Word;
    }
    public int CurrentBook { get; set; }
    public int Chapter { get; set; }
    public int Verse { get; set; }
    public string Word { get; set; }
}
