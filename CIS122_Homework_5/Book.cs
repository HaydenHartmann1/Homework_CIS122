/*
    Hayden Hartmann
    2/27/2025
    This file contains Animal and sub classes 
*/

public class Book
{
    protected string _title = "n/a";
    protected string _author = "n/a";
    protected string _yearPublished = "n/a";

    public Book(string title, string author, string yearPublished)
    {
        _title = title;
        _author = author;
        _yearPublished = yearPublished;
    }

    public override string ToString()
    {
        return $"{_title} by {_author} ({_yearPublished})";
    }
}

public class Ebook : Book
{
    protected string _fileSizeMB = "n/a";

    public Ebook(string fileSizeMB, string author, string title, string yearPublished) : base (title, author, yearPublished)
    {
        _fileSizeMB = fileSizeMB;
    }

    public override string ToString()
    {
        return $"{_title} by {_author} ({_yearPublished}), EbookFileSize: {_fileSizeMB}";
    }
}

public class Printedbook : Book
{
    protected string _pageCount = "n/a";

    public Printedbook(string pageCount, string author, string title, string yearPublished) : base(title, author, yearPublished)
    {
        _pageCount = pageCount;
    }

    public override string ToString()
    {
        return $"{_title} by {_author} ({_yearPublished}), EbookFileSize: {_pageCount}";
    }
}

