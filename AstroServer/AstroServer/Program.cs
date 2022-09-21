using System;
using System.ServiceModel;


// 3.	Create a ServiceHost and NetNamedPipeBinding in the “Program.cs” file to provide connection for the client(s). Ensure to add a Console.ReadLine to pause the program during operation

namespace AstroServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string address = "net.pipe://localhost/PipeAstro";

            ServiceHost serviceHost = new ServiceHost(typeof(AstroServer));
            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            serviceHost.AddServiceEndpoint(typeof(IAstroContact), binding, address);
            serviceHost.Open();

            Console.WriteLine("press enter to exit.");
            Console.ReadLine();
            serviceHost.Close();
        }
    }
}
