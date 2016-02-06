This will not work if you do not have access to a database.

 - For MySQL servers, you must have the Server Name, Database Name, Username, and Password.
 - For SQL servers, you must have a ready-made connection string. 

Currently, most error-checking has been added, but SSL support is not yet implemented. 

## Currently Supported Languages ##

 - English (KJV)
 - Simplified Chinese
 - Traditional Chinese

## Current Database Support ##

 - MySQL
 - SQL Server 2008-2014

##Adding New Languages##

Fortunately, adding new languages has been made easier.

 1. Simply implement the `IFlatFile` interface and do what's necessary to load the appropriate values into the `BibleCollection` object, then insert the collection into the `FullCollection` object named in `MemoryStorage.cs`.
  - Check `EnglishKjv.cs`, `ChineseSimplified.cs`, and `ChineseTraditional.cs` for examples. 
  - Note that, for non-ASCII languages, you may need to use/convert to the appropriate encoding: if the values show up as `???` while watching variables in the debugger, your encoding is not correct. This means it won't insert correctly, and you'll end up with question marks in the database.
 2. Edit `QueryLanguage.cs` and update the `Enum` to support your new language. For example: `, Russian = 3` The program will take care of the rest for you and insert everything.
 3. Run program.
