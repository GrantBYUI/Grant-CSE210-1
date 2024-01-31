using System;
using System.Diagnostics.Contracts;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
// Constructor
    public Scripture(Reference reference,string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] wordArray = text.Split(" ");
        // Create Word objects for each word in the array   
        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }

        public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        HashSet<int> usedIndices = new HashSet<int>();
        for (int i = 0; i < numberToHide; i++);
        {
            int index;

            do
            {
                index = random.Next(_words.Count);
            } while (usedIndices.Contains(index));

            _words[index].Hide();
            usedIndices.Add(index);
        }
    }

        public string GetDisplayText()
        {
            // string displayText = $"(_reference.GetDisplayText)()";
            // foreach (Word word in _words)
            // {
            //     displayText = $"("displayText") ("word.GetDisplayText")();
            // }
            // return displayText.Trim();
            return "";
        }

        public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden()==false)
            {
                return false;
            }
        }
        return true; 
    }
        
}