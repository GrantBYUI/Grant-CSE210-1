using System;
public class Reference
{
    public string _book;
    public int _chapter;
    public int _verse;
    public int _endVerse;

    public Reference (string book, int chapter, int verse)
       {
        _book = book;
        _chapter = chapter;
        _verse =  verse;
       }
       public Reference (string book, int chapter, int verse, int endverse)
       {
        _book = book;
        _chapter = chapter;
        _verse =  verse;
        _endVerse = endverse;
       }
}