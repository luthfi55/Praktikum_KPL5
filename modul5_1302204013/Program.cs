using System;

namespace modul5_1302204013
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SayaTubeVideo video = new SayaTubeVideo("Review Film Shutter Island oleh Luthfi");
            SayaTubeVideo video1 = new SayaTubeVideo("Review Film Gone Girl oleh Luthfi");
            SayaTubeVideo video2 = new SayaTubeVideo("Review Film Conjuring oleh Luthfi");
            SayaTubeVideo video3 = new SayaTubeVideo("Review Film Insidious oleh Luthfi");
            SayaTubeVideo video4 = new SayaTubeVideo("Review Film Sing oleh Luthfi");
            SayaTubeVideo video5 = new SayaTubeVideo("Review Film Venom oleh Luthfi");
            SayaTubeVideo video6 = new SayaTubeVideo("Review Film Taken oleh Luthfi");
            SayaTubeVideo video7 = new SayaTubeVideo("Review Film John Wick oleh Luthfi");
            SayaTubeUser user = new SayaTubeUser("Luthfi");

            video.IncreasePlayCount(1);
            video1.IncreasePlayCount(2);
            video2.IncreasePlayCount(10);
            video3.IncreasePlayCount(100);
            video4.IncreasePlayCount(9);
            video5.IncreasePlayCount(9);
            video6.IncreasePlayCount(7);
            video.IncreasePlayCount(7);

            user.AddVideo(video);
            user.AddVideo(video1);
            user.AddVideo(video2);
            user.AddVideo(video3);
            user.AddVideo(video4);
            user.AddVideo(video5);
            user.AddVideo(video6);
            user.AddVideo(video7);

            video3.PrintVideoDetails();

            user.PrintAllVideoPlaycount();
        }
    }
}
