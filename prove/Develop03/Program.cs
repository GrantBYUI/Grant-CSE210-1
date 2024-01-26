using System;

class Program
{
        static void Main(string[] args)
        {
            Reference reference = new Reference("John", 3, 16);
            Scripture scripture = new Scripture("reference, For God so loved the world, he sent his only begotton son");

            while (scripture.IsCompletelyHidden()==false);
            {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit:");
            string userInput = Console.Readline();

            if(userInput.ToLower() == "quit")
            {
                break;
            }
             
             scripture.hiderandomwords(2);
        }
         }
}