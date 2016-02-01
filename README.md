This will not work if you do not have access to a database.

 - For MySQL servers, you must have the Server Name, Database Name, Username, and Password.
 - For SQL servers, you must have a ready-made connection string. 

Currently, most error-checking has been added, but SSL support is not yet implemented. 

**Supports the following languages:**

 - English (KJV)
 - Simplified Chinese
 - Traditional Chinese

**Supports the following Databases:**

 - MySQL
 - SQL Server 2008-2014

**Adding New Languages**

Adding new languages is easy. 
 - Simply implement the `IFlatFile` interface and do what's necessary to load the appropriate values into the `BibleCollection` object. 
 - Check `EnglishKjv.cs`, `ChineseSimplified.cs`, and `ChineseTraditional.cs` for examples. 
 - Note that you may need to use/convert to the appropriate encoding: if the values show up as `???` while watching variables in the debugger, your encoding is not correct. This means it won't insert correctly, and you'll end up with question marks in the database.
