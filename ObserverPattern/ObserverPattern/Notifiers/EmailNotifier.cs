﻿using System;
using ObserverPattern.Base;

namespace ObserverPattern.Notifiers
{
    public class EmailNotifier : Observer
    {
        public EmailNotifier(Subject subject)
        {
            this.subject = subject;
            this.subject.AttachObserver(this);
        }

        public override void Notify(Subject subject, object arg)
        {
            if (subject is VideoData videoData)
            {
                Console.WriteLine(
                    string.Format($"Notify all subscribers via Email with new data" +
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
