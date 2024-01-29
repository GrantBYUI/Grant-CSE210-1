using System;

// responsible for storing the objects of your entry class
public class Journal
{
// Attribute
  public List<Entry> entries = new List<Entry>();
    // Method
    public void Addentry(Entry journal_entry)
    {
        this.entries.Add(journal_entry);
    }
     // Method
     public void AddDisplay()
     {
      //   Console.WriteLine(adddisplay);
     }

     // Method 
     public void WriteToFile()
     {
      //   Console.WriteLine(addwritetofile);
     }

     // Method
     public void LoadFromAFile()
     {
      //   Console.WriteLine(loadfromafile);
     }
 }