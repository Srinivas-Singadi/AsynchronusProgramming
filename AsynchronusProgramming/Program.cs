using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronusProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloadig the file");
           // Download();
            Console.ReadLine();
       

        }

        private static async void Download(var x , var y, var z)
        {
            HttpClient client = new HttpClient();
            var data =await client.GetAsync("https://www.udemy.com/join/login-popup/?next=/home/my-courses/learning/");
            Console.WriteLine("Download COmpleted "+ data);


            //TODO
            //one more TODO
            
            //From the orogin/master
        }
    }
}
