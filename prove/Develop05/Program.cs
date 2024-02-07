//outputFile.WriteLine("This will be the first line in the file.");
using System;
using System.IO.StreamWriter

class Program
{
    static void Main(string[] args)
    {
        //AddDisplay("user's score.");
        //get ("usergoals");
        //get ("user accomplished goals");
        //Show ("User list of the goals. completed");
        //Save ("user"s goals and score to a file");
        //get("user's goals and score to be saved and loaded.");
    }

    {
        //Add your own ideas for gamification. This could include leveling up, earning certain bonuses, or other "fun" aspects to the quest.
        //Add additional kinds of goals, such as the ability to make progress towards a large goal (such as getting value for working towards running a marathon), or "negative goals" where they lose points for bad habits.
        //There are lots of ways to show creativity in this assignment. Pick anything that sounds fun to you!
    }

    {
        //The easiest way to read a text file in C# is to read the entire file into an array of strings (one per line) using the System.IO.File.ReadAllLines() function. Then, you can iterate through each string as you would with any list.
    }

        //string filename = "myFile.txt";
        //string[] lines = System.IO.File.ReadAllLines(filename);

        //foreach (string line in lines)
        {
            //string[] parts = line.Split(",");

            //string firstName = parts[0];
            //string lastName = parts[1];
        }

        //string fileName = "myFile.txt";

        //using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            //outputFile.WriteLine("This will be the first line in the file.");
    
            // You can use the $ and include variables just like with Console.WriteLine
            //string color = "Blue";
            //outputFile.WriteLine($"My favorite color is {color}");
        }

        //GetStringRepresentation();
        //"Person:Brigham,Young"

        //(Person) and the details ("Brigham,Young"). Then, you could create a method called CreatePerson that would accept the string of details ("Brigham,Young"). This method could split the string on the commas to get the various items. Then, it could create a new Person object, set all the values, and return it.
}