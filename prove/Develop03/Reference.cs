using System;
using static System.Console;

// Using static and system allows you to reference information without  having to call the full path,
//  like Console.Writeline. instead I could use Writeline()

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int? _verseEnd;




    public Reference(string book, int chapter, int verseStart, int? verseEnd = null)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }


    public string GetBook()
    {
        return _book;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public int GetVerseStart()
    {
        return _verseStart;

    }
    public int? GetVerseEnd()
    {
        return _verseEnd;
    }

}
