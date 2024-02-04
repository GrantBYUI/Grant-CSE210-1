using System;

public class Program
{
    //Attribute
    public static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish but have everlasting life.");
        scriptures.Add(scripture);
        reference = new Reference("Proverbs", 3, 5,6);
        scripture = new Scripture(reference,"Trust in the Lord with all thine heart; and lean unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths " );
        scriptures.Add(scripture);
        Console.WriteLine("scriptures");
        Console.WriteLine ("reference");
        Console.Write("please enter your scripture here");
        Console.ReadLine();
        Console.WriteLine("the scripture is {Proverbs 3, 5,6}");
        Console.WriteLine("Trust in the Lord with all thine heart; and lean unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths");
        //while (scripture.IsCompetelyHidden()==false);
        Console.ReadLine();
        Console.WriteLine("press enter to continue or type quit to finish:");
        return;
    }

    // Method
     //public List Addreference(reference _scripturereference)
     //{
        //Reference reference = new Reference("John", 3, 16);
       // Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish but have everlasting life.");
        // Reference reference = new Reference("Proverbs", 3, 5-6);
        // Scripture scripture = new Scripture(referance, "Trust in the Lord with all thine heart; and lean unto thine own understanding");
        // Scripture scripture = new Scripture(referance, "In all thy ways acknowledge him, and he shall direct thy paths");
            // while (scripture.IsCompletelyHidden()==true){}
            // if (userInput.toHigh= "display");
            // Console.WriteLine(scripture.GetDisplayText);

            // while (scripture.IsCompetelyHidden()==false);
            // Console.Clear();
            // Console.WriteLine("Press Enter to hide more words or type 'quit' to exit:");
            // string userInput = Console.ReadLine();
            // if (userInput.ToLow() == "quit")
            // {
            //     break;
            // }

            // scripture.HideRandomWords(2);

     //}
}