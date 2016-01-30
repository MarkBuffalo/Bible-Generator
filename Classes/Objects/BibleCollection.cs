/// <summary>
/// The data from the Bible. Chapter, Verse, Word of God. It also includes a CurrentBook integer, which is used to link to the Book Collection. This saves memory.
/// </summary>
public class BibleCollection
{
    public BibleCollection(string CurrentBook, int Chapter, int Verse, string Word)
    {
        this.CurrentBook = CurrentBook;
        this.Chapter = Chapter;
        this.Verse = Verse;
        this.Word = Word;
    }
    public string CurrentBook;
    public int Chapter;
    public int Verse;
    public string Word;
}
