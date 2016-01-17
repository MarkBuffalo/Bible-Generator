/// <summary>
/// The Books of the Bible, with an accompanying Id.
/// </summary>
public class BookCollection
{
    public BookCollection(int Id, string Book)
    {
        this.Id = Id;
        this.Book = Book;
    }
    public int Id;
    public string Book;
}
