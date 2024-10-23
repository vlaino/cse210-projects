using System;

public class Comment
{
    public string _name;
    public string _text;

    public Comment (string name, string text)
    {
        _name = name;
        _text = text;
    }

    public string GetCommentName()
    {
        return _name;
    }

    public string GetComment()
    {
        return _text;
    }
}