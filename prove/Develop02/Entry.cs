using System;
   
   //responisble for storing responses, prompts and dates
  // responsible for being able to display journal information
public class Entry
{
    // Attributes
    public string _date;
    public string _response;
    public string _prompt;

    // Constructor
    public Entry()
    {
    }

    // Methods
    public void Display() // Display Contents
    {
        Console.WriteLine(this._date);
        Console.WriteLine(this._prompt);
        Console.WriteLine(this._response);
    
    }

    public void GetResponse() // Answer to Prompt
    {
        Console.WriteLine("your response here -> ");
        this._response = Console.ReadLine();
    }

    public void GetDate()
    {
        Console.WriteLine("What is today's date?");
       this._date = Console.ReadLine();
    }
    public void StorePrompt(string prompt)
    {
        this._prompt = prompt;
    }
}