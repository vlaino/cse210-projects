using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new();
        void DisplayVideo()
        {
            int count = 0;
            foreach (Video video in videos)
            {
                count++;
                Console.WriteLine($"Video0{count}");
                video.DisplayInfVideo();
                Console.WriteLine("\nComments: ");
                video.DisplayComment();
            }
        }

        Video video1 = new();
        Video video2 = new();
        Video video3 = new();

        Comment comment = new("Andrea", "This is not about languages; this is about life attitude");

        //Video 1
        video1.VideoInf("Marianna Pascal", "Learning a language?", 900);
        video1.NumberOfComments(comment);

        comment = new("Leandro", "She's exactly right");
        video1.NumberOfComments(comment);

        comment = new("Joshua", "English isn’t an art to be mastered, it’s a tool to use to get the result.");
        video1.NumberOfComments(comment);

        videos.Add(video1);


        //Video 2
        video2.VideoInf("Tom Chi", "Everything is Connected", 1080);
        video2.NumberOfComments(comment);

        comment = new("Frannie", "I love this");
        video2.NumberOfComments(comment);

        comment = new("Peter", "The speaker knows the stuff scientifically as well spiritually.");
        video2.NumberOfComments(comment);

        videos.Add(video2);


        //Video 3
        video3.VideoInf("Neal Barnard", "Power Foods for the Brain", 1020);
        video3.NumberOfComments(comment);

        comment = new("Arnold", "Very good information");
        video3.NumberOfComments(comment);

        comment = new("Natalia", "I’m so glad I found this video while studying for my anatomy class.");
        video3.NumberOfComments(comment);

        videos.Add(video3);
        DisplayVideo();
    }
}