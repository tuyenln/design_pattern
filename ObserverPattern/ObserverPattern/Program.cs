using System;
using ObserverPattern.Notifiers;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoData = new VideoData();

            var emailNotifier = new EmailNotifier(videoData);
            var phoneNotifier = new PhoneNotifier(videoData);
            var youtubeNotifier = new YoutubeNotifier(videoData);

            videoData.SetTitle("Observer test");
            videoData.DetachObserver(youtubeNotifier);
            Console.WriteLine("--------------------------------------------");
            videoData.SetDescription("test new");

            _ = new FacebookNotifier(videoData);
            Console.WriteLine("--------------------------------------------");
            videoData.SetFileName("test FB");


        }
    }
}
