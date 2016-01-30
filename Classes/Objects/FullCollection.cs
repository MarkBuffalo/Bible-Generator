using BibleProject.Classes.Objects;
using BibleProject.Classes;
using System.Collections.Generic;

/// <summary>
/// Stores both List<BibleCollection> and List<BookCollection> for easier access.
/// </summary>
public class FullCollection
{
    public FullCollection(List<BibleCollection> BibleCollection)
    {
        this.BibleCollection = BibleCollection;
        //this.BookCollection = BookCollection;
    }
    public List<BibleCollection> BibleCollection { get; set; }
    //public List<BookCollection> BookCollection { get; set; }

}