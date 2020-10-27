using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CommandAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting My App");
            Console.WriteLine("Number of args = " + args.Length);
            foreach (var a in args)
                Console.WriteLine(a);

            Console.WriteLine("End of Args");

            var host = CreateHostBuilder(args).Build().RunAsync();

            Console.WriteLine("This point is reached after CreateHostBuilder(args).Build().Run(); line");
            while (true)
            {
                Console.Write("Type exit to terminate server: ");
                if (Console.ReadLine().ToLower() == "exit") break;
            }
            int count = 10;
            var s = "Shutting down server in: ";
            Console.Write(s);
            Console.CursorVisible = false;
            do
            {
                Console.CursorLeft = s.Length;
                Console.Write(count.ToString().PadRight(3));
                var n = DateTime.Now.AddSeconds(1);
                while (n >= DateTime.Now) ;
                count--;
            } while (count > 0);
            Console.CursorLeft = s.Length;
            Console.WriteLine("Now!");
            host.Wait(500);
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
