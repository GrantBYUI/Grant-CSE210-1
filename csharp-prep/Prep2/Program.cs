using System;

 class Program
 {       
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string answer= Console.ReadLine();
        int percent = int.Parse(answer);

        string letter ="";
        
        if(percent >= 90)
        {
            letter ="V";
        }
        if(percent >= 80)
        {
            letter ="W";
        }
        if(percent >= 70)
        {
            letter ="x";
        }
        if(percent >= 60)
        {
            letter ="y";
        }
        if (true)
        {
            letter ="z";
        }

             Console.WriteLine($"your letter grade is: {letter}");

             if (percent >= 60)
             {
             Console.WriteLine("Congratulations you passed! ");
             
             {
                Console.WriteLine("Better luck next time!");
             }
             }
    }
 }