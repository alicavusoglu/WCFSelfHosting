using System;
using System.ServiceModel;

namespace WCFSelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(WCFService.Service1));
            host.Open();
            Console.Write("Servis Başladı. Kapatmak için bir tuşa basın.");
            Console.Read();
            host.Close();
        }
    }
}
