using System;

// Responsible for hold different journal prompts.
// will randomly select a prompt when asked
public class Prompts
{
// Attributes
public List<string> _prompts = new List<string>();

 // Constructor
 public Prompts()
 {
    this._prompts.Add("Who was the most interesting person I interacted with today?");
    this._prompts.Add("What was the best part of my day");
    this._prompts.Add("How did I see the hand of the lord in my life?");
    this._prompts.Add("What was the strongest emotion I  felt today?");
    this._prompts.Add("If I had one thing I could do over again today, what would it be?");
 }

    //Methods
    public string GetPrompt()
    {
      // gets a random prompt for the user so that their journal isn't the same everyday
      Random rnd = new Random();
      int select = rnd.Next(0, this._prompts.Count-1);

      return this._prompts[select];
    }
}