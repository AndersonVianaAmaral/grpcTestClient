using Grpc.Net.Client;
using GrpcService;
using System;
using System.Threading.Tasks;

namespace GRPC_Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var i = 0;
            while (i <= 10000)
            {
                var client = new Greeter.GreeterClient(GrpcChannel.ForAddress("https://localhost:5001"));
                var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });
                Console.WriteLine("Greeting: " + reply.Message +"    " + i);
                i++;
            }
            
            Console.ReadKey();
        }
    }
}
