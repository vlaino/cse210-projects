using System;

public class Reference
{
    private string _book;
    private List<int> _chapters;
    private List<(int startVerse, int endVerse)> _versesRanges;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapters = new List<int> { chapter };
        _versesRanges = new List<(int, int)> { (verse, verse) };

    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapters = new List<int> { chapter };
        _versesRanges = new List<(int, int)> { (startVerse, endVerse) };

    }

    public override string GetDisplayText()
    {
        return $"{_book} {_chapter}: {verse}";
        /*string referenceString = $"{_book} ";
        for (int i = 0; i < _chapters.Count; i++)
        {
            referenceString += $"{_chapters[i]}:";
            referenceString += $"{_versesRanges[i].startVerse}";

            if (_versesRanges[i].startVerse != _versesRanges[i].endVerse)
            {
                referenceString += $"-{_verseRange[i].endVerse}";
            }

            if (i < _chapters.Count -1)
            {
                referenceString += ",";
            }
        }

        return referenceString;*/

    }
}