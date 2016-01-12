using BibleProject.Classes.Objects;
using BibleProject.Classes;
using System.Collections.Generic;

/// <summary>
/// Stores both List<BibleCollection> and List<BookCollection> for easier access.
/// </summary>
public class FullCollection
{
    public FullCollection(List<BibleCollection> _BibleCollection, List<BookCollection> _BookCollection)
    {
        BibleCollection = _BibleCollection;
        BookCollection = _BookCollection;
    }
    public List<BibleCollection> BibleCollection { get; set; }
    public List<BookCollection> BookCollection { get; set; }

}