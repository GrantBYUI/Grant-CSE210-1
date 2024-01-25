using system;

 // responsible for storing the objects of your entry class
public class Journal
{


    // Variable
    public Prompt _prompt = new Prompt();
    public List<Entry> _entries = new List<Entry>();


     // Constructor
     public journal()
    {
    }

     // Methods
     public void Write() // prompt the user to write in their journal
    {
        // create a new entry = new entry();
        Entry entry = new Entry();
        string query = this._prompt.Get Prompt();

        // collect your users responses
        entry.Getdate();
        entry.signiture();
        Console.WriteLine(query);
        entry.Getresponse();

        // store the prompt
        entry.HoldPrompt(query);

        // add the entry to the list 
        this._entries.Add(entry);
    }

    public void(Display)
    {
      foreach(entry entry in._this._entries)
      {
        Console.WriteLine();
        Entry.Display();
      }
    }
}