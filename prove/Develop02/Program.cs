using System;
using System.Collections;

//responsible for running the Program

class Program
   {
      static void Main()
   {
      // Variables
      Journal journal = new journal();
      int input = 0;

      // Welome Message
      Console.WriteLine("Welcome to the best journal program that will solve many of your journal keeping needs");

      //Main Menu
      do
      {
         Console.WriteLine(); // New Line Space
         Console.WriteLine("Main Menu:");
         Console.WriteLine(" 1.Display your journal");
         Console.WriteLine(" 2. Write in your journal");
         Console.WriteLine(" 3. Save your journal to a .text file");
         Console.WriteLine(" 4. Load a journal from a .text file");
         Console.WriteLine(" 5. Exit Program");
         Console.WriteLine("your choice here ->")
         // User Choice
         input = int.Parse(   Console.ReadLine());
         // interpret user choice
         switch (input)
      {
          Case 1: // Display
               journal.Display();
               break;
               Case 2: // Write
               journal.Write();
               break;
               Case 3: // save
               Save(Journal);
               break;
               Case 4: // load
               Load(Journal)
               break;
               Case 5:  // Exit
               Exit(Program)
               break;
               Case 6: // Choice
               Your Choice
 }
      }
   }
   }