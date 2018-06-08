using System;
using System.IO;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = Directory.GetCurrentDirectory() + "/html";
            HTTPServer myServer = new HTTPServer(directory, "127.0.0.1", 3001);
            myServer.Start();
        }
    }
}
