using static System.Net.WebRequestMethods;

namespace VererbungDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Post post1 = new Post("Meine neuen Schuhe sind geil!!",true,"Marvin Stiegler");
            Console.WriteLine("Post ToSring Methode:{0}" , post1.ToString());
            
            BildPost bildPost1 = new BildPost("hier sind sie!", "Marvin Stiegler", "https://bild.de/meinescuhe", true);
            Console.WriteLine("ImagePost ToString Methode : {0}",bildPost1.ToString());

            VideoPost videoPost1 = new VideoPost("Mein Erstes Video!","Marvin Stiegler",true,"https://Video.de/meinSalto",10);
            
            Console.WriteLine("{0}",videoPost1.ToString());

            // zusatz Timer

            videoPost1.Play();
            Console.ReadKey(); // für Stop
            videoPost1.Stop();
        }
    }
}
