using System;
using System.Collections.Generic;

namespace modul5_1302204013
{
    public class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        private string Username;
        public SayaTubeUser(String username)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.uploadedVideos = new List<SayaTubeVideo>();
            if (username == "")
                throw new NullReferenceException("Username harus terisi");
            if (username.Length > 100)
                throw new Exception("Username maksimal 100 karakter");
            this.Username = username;
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            int i = 0;
            while (i < uploadedVideos.Count)
            {
                total = total + uploadedVideos[i].getPlayCount();
                i++;
            }

            return total;
        }
        public void AddVideo(SayaTubeVideo a)
        {
            uploadedVideos.Add(a);
        }

        public void PrintAllVideoPlaycount()
        {
            int i = 0;
            Console.WriteLine("User : " + this.Username + "\n");

            while (i < uploadedVideos.Count)
            {
                Console.WriteLine("Video " + (i + 1) + " Judul: " + uploadedVideos[i].getTitle());
                i++;
            }

            Console.WriteLine("\nTotal playcount daru semua video: " + GetTotalVideoPlayCount());

        }
    }
}
