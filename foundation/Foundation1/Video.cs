using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public void NumberOfComments(Comment comment)
    {
        _comments.Add(comment);

    }

    public void VideoInf(params object[] args)
    {
        _author = args[0].ToString();
        _title = args[1].ToString();
        _length = int.Parse(args[2].ToString());
    }

    public string GetAuthor()
    {
        return _author;
    }

    public string GetTitle()
    {
        return _title;
    }

    public int GetLength()
    {
        return _length;
    }

    public void DisplayComment()
    {
        foreach(Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetCommentName()} - {comment.GetComment()}");

        }
        Console.WriteLine();
    }

    public void DisplayInfVideo()
    {
        string info = $"Author of Video: {GetAuthor()} \nTitle: {GetTitle()}\n Length: {GetLength()} seconds";
        Console.WriteLine(info);
    }
}