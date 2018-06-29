using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

namespace Ema_Project
{
    class Program
    {
        List<string> listSongs = new List<string>();


        static void Main(string[] args)
        {

            Console.WriteLine("we, benvenuto, scrivi il testo che cerchi");
            search(Console.ReadLine());
            Console.ReadKey();
        }

        public void search(string s)
        {

            //listSongs.Exists(delegate (string a) { return a = s};
            //bool a =listSongs.Exists()
            //if (listSongs.Exists(a => a = s))
            //{

            //}
        }
    }
}
