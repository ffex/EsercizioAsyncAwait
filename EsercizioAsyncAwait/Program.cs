using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EsercizioAsyncAwait
{
    class Program
    {
        static private void ScaricaPaginaWeb(string url)
        {
            WebClient webClient = new WebClient();
            string page = webClient.DownloadString(url);
            //Console.WriteLine(page);
            Console.WriteLine("Metodo normale: Fine");
        }
        static private async Task ScaricaPaginaWebAsync(string url)
        {
            WebClient webClient = new WebClient();
            string page = await webClient.DownloadStringTaskAsync(url);
            //Console.WriteLine(page);
            Console.WriteLine("Metodo async: Fine");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Metodo normale: Avvio");
            ScaricaPaginaWeb("http://youtube.com");

            Thread t1 = new Thread(() => ScaricaPaginaWeb("http://google.com"));
            Task.Run(() => ScaricaPaginaWeb("http://google.com"));

            Console.WriteLine("Metodo async: Avvio");
            ScaricaPaginaWebAsync("http://youtube.com");

            
            







            


            Console.ReadLine();

        }
    }
}
