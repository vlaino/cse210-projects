using System;

public class Word
{
    private string _word;

    public Word(string word)
    {
        _word = word;

    }

    public string Hide()
    {
        return _word = "__";

    }


    public bool IsHidden(string word)
    {
        if (word == "_")
        {
            return true;
        }
        else
        {
            return false;
        }

    }

   

    
}