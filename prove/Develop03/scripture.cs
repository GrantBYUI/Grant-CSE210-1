using System;
using System.Diagnostics.Contracts;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructor
    public Scripture(Reference Reference,string text){
        _reference = Reference;
        _words = new List<Word>();
        string[] wordArray = text.Split(" ");
        // Create Word objects for each word in the array   
        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    Random random = new Random();
    HashSet<int> usedIndices = new HashSet<int>();
    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
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

    public string GetDisplayText(){
        string displayText = $"{_reference.GetDisplayText()}\n";
        foreach (Word word in _words){
            displayText = $"{displayText}{word.GetDisplayText()} ";
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden(){
        foreach (Word word in _words){
            if (word.IsHidden()==false){
                return false;
            }
        }
        return true;
    }
}