using System;
using System.Diagnostics;

namespace MyDownloaderCli
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] lines = System.IO.File.ReadAllLines("links.txt");

            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);

                Process yt = new Process();
                yt.StartInfo.FileName = "youtube-dl.exe";
                yt.StartInfo.Arguments = line;

                yt.StartInfo.UseShellExecute = false;
                yt.StartInfo.RedirectStandardOutput = true;
                yt.Start();

                string output = yt.StandardOutput.ReadToEnd();
                Console.WriteLine(output);

                yt.WaitForExit();


            }
        
        }
    }
}
