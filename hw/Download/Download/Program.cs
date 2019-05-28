using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Download
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new WebClient();
            Console.WriteLine("Скачивается файл");
            string file = client.DownloadString("https://dl.google.com/dl/android/studio/install/3.4.1.0/android-studio-ide-183.5522156-windows.exe");
        }
    }
}
