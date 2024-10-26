using System;
using System.Collections.Generic;

public class Scripture
{
    //private Reference _reference;
    private List<string> _words = new List<string>();
    //private Random _random = new Random();

    public Scripture(string text)
    {
        List<string> wordsList = new List<string>(text.Split(" "));
        _words.AddRange(wordsList);
        /*_reference = reference;
        string[] strAry = _text.Split();
        foreach (string word in strAry)
        {
            Word wordObj = new Word(word);
            _words.Add(wordObj);  
        }*/
    }

    public void HideRandomWords()
    {
        Random random = new Random();

        bool run = true;
        while(run)
        {
            int randomNumber = random.Next(_words.Count);

            Word singleWord = new Word(_words[randomNumber]);
            if (singleWord.IsHidden(_words[randomNumber]) != true)
            {
                string change = singleWord.Hide();
                _words[randomNumber] = change;
                run = false;
            }
        }
        /*int wordsHidden = 0;

        while (wordsHidden < numberToHide && !IsCompletelyHidden())
        {
            int index = _random.Next(_words.Count);

            if(!_words[index].IsHidden())
            {
                _words[index].Hide();
                wordsHidden++;
            }
        }*/

    }

    public string GetDisplayText()
    {
        return string.Join(" ", _words);
        /*List<string> displayWords = new List<string>();

        foreach (Word word in _words)
        {
            if (_words.IsHidden)
            {
                displayWords.Add(new string ("_", word._text.Length));
            }
            else
            {
                displayWords.Add(word._text);
            }
        }*/

    }

    public bool IsCompletelyHidden()
    {
        int count = 0;
        foreach (string word in _words)
        {
            if (word == "__")
            {
                count += 1;
            }
        }

        int lenghtVerse = _words.Count();
        if (count == lenghtVerse)
        {
            return true;
        }
        else
        {
            return false;
        }
    

    }
}