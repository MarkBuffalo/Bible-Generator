/// <summary>
/// The Books of the Bible, with an accompanying Id.
/// </summary>
public class BookCollection
{
    public BookCollection(int _Id, string _Book)
    {
        Id = _Id;
        Book = _Book;
    }
    public int Id;
    public string Book;
}
