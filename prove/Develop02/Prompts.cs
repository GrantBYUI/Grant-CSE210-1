using system;

// Responsible for hold different journal prompts.
// will randomly select a prompt when asked
public class prompts
{
// Attributes
public list<string> _prompts =new List<string>();

 // Constructor
 public Prompts
 {
    this._prompts.add("Who was the most interesting person I interacted with today?");
    this._prompts.add("What was the best part of my day");
    this._prompts.add("How did I see the hand of the lord in my life?");
    this._prompts.add("What was the strongest emotion I  felt today?");
    this._prompts.add("If I had one thing I could do over again today, what would it be?");
 }

    //Methods
    public string GetPrompt() newRandom();
    {

    int.select = RandomGenerator.Next(0, thisprompts.count-1);

    return this.prompts(select);
    }
}