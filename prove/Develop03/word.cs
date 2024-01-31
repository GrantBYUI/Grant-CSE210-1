using System;

public class Word
{
    public string _text;
    public bool _isHidden;

 // Constructor
    public Word(string text)
    {
        _text=text;
    }

    // Methods
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if(_isHidden == true)
        {
            return "________";
        }else{
            return _text;
        }
    }
}