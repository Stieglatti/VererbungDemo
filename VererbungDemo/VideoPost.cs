using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace VererbungDemo
{
    internal class VideoPost : Post
    {
        public string VideoURL { get; set; }
        public int Length { get; set; }


        // Eigenschaft für Timer
        private System.Timers.Timer timer;
        private int currentTime;






        public VideoPost() { }

        public VideoPost(string title, string sendByUsername, bool istPublic, string VideoURL, int Length)
        {
            // erbt von der Klasse Post
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUsername;
            this.IsPublic = istPublic;


            // nur in dieser Klasse 
            this.Length = Length;
            this.VideoURL = VideoURL;

            // Timer Kunstruktor ergänzen
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimeElapsed;
            timer.AutoReset = true;

            currentTime = 0;
        }

        public override string ToString()
        {
            return String.Format("Das Video von {0} - {1} - von {2} länge {3} {4}", this.ID, this.Title, this.SendByUserName, this.Length, this.VideoURL);
        }


        // Methode für Callback
        private void OnTimeElapsed(object? sender, ElapsedEventArgs e)
        {
            currentTime++;

            Console.WriteLine("Aktuelle Laufzeit:{0}s", currentTime);

            if (currentTime >= Length)
            {

                Stop();
                Console.WriteLine("Video beendet");

            }

        }

        // Play Methode

        public void Play()
        {

            Console.WriteLine("Video startet");
            timer.Start();

        }

        // Stop Methode 
            
            public void Stop()
            { timer.Stop();

            Console.WriteLine($"Angehalten bei {currentTime}s");        
            }


    }             
}
