using System;
namespace modul5_1302204013
{
    public class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            if (title == "")
                throw new NullReferenceException("Title harus terisi");
            if (title.Length > 200)
                throw new Exception("Title maksimal 200 karakter");

            this.title = title;

            this.playCount = 0;
        }

        public void IncreasePlayCount(int a)
        {
            this.playCount = a;
        }

        public int getPlayCount()
        {
            return this.playCount;
        }

        public String getTitle()
        {
            return this.title;
        }

        public void PrintVideoDetails()
        {
            {

                Console.WriteLine("ID Video : " + this.id);
                Console.WriteLine("Title Video : " + this.title);
                Console.WriteLine("Playcount Video : " + playCount);
                Console.WriteLine();
            }
        }
    }
}
