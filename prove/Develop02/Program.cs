using System;
//responsible for running the Program
// 

internal class Program
{
    public  static void main(string[] args)

      // Method  //  Menu
      {
            Prompts journal_prompt = new Prompts();
            string prompt_string = journal_prompt.GetPrompt();
            Console.WriteLine(prompt_string);
      }
}
      