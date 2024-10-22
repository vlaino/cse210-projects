using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] strAry = text.Split();
        foreach (string word in strAry)
        {
            Word wordObj = new Word(word);
            _words.Add(wordObj);  
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int wordsHidden = 0;

        while (wordsHidden < numberToHide && !IsCompletelyHidden())
        {
            int index = _random.Next(_words.Count);

            if(!_words[index].IsHidden)
            {
                _words[index].Hide();
                wordsHidden++;
            }
        }

    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();

        foreach (Word word in _words)
        {
            if (word.IsHidden)
            {
                displayWords.Add(new string ("_", word.Text.Length));
            }
            else
            {
                displayWords.Add(word.Text);
            }
        }

    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }
        return true;

    }
}