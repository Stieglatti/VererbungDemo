using System;
using System.Collections.Generic;
using System.Text;

namespace VererbungDemo
{
    // BildPost erbt von Post und fügt eine Eigenschaft (ImageURL) und zwei Konstruktoren hinzu
    

    internal class BildPost : Post
    {
        public string ImageURL { get; set; }

        public BildPost() { }

        public BildPost(string title, string sendByUsername, string imageURL, bool istPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUsername;
            this.IsPublic = istPublic;


            //Eigenschaft ImageURL welche ein Member der ImagePost Klasse ist. Jedoch nicht von Post.
            this.ImageURL = imageURL;


        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - von {2} URL{3}", this.ID, this.Title, this.SendByUserName,this.ImageURL);
        }
    }
   
}
