﻿using System;
using ObserverPattern.Base;

namespace ObserverPattern.Notifiers
{
    public class YoutubeNotifier : Observer
    {
        public YoutubeNotifier(Subject subject)
        {
            this.subject = subject;
            this.subject.AttachObserver(this);
        }

        public override void Notify(Subject subject, object arg)
        {
            if (subject is VideoData videoData)
            {
                Console.WriteLine(
                    string.Format($"Notify all subscribers via YOUTUBE with new data" +
                    "\n\tName: {0}" +
                    "\n\tDescription: {1}" +
                    "\n\tFile name : {2}",
                    videoData.GetTitle(),
                    videoData.GetDescription(),
                    videoData.GetFileName()
                    )
                );

            }
        }
    }
}
