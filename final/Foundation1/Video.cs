using System;
   
   //responsible for storing responses, prompts and dates
  // responsible for being able to display journal information
public Class Video
{
    // Attributes
    {
        public string _title;
        public string _author;
        public string _length;
        public string _comments;
    }
    // Constructor
    public Video();
    {
    }

    // Methods
    public void Display() // Display Comments
    {
        Console.WriteLine(this._title);
        Console.WriteLine(this._author);
        Console.WriteLine(this._length);
    
    }

    public void comment();
    {
        Console.WriteLine("your comment here -> ");
        this._response = Console.ReadLine();
    }

    public void GetComment()
    {
        Console.WriteLine("Who is the author?");
        Console.WriteLine("your comment here ->");
        this._author = Console.ReadLine();
    }
    public void StoreComments(string comments)
    {
        Console.WriteLine("your comment here ->");
        this._comment = comment;
    
        Console.WriteLine("your comment here ->");
        return 4;
}