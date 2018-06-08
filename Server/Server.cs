using System;
using System.IO;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = Directory.GetCurrentDirectory() + "/html";
            HTTPServer myServer = new HTTPServer(directory, "192.168.1.120", 3001);
            myServer.Start();
        }
    }
}
