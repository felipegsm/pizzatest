using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace pizzatest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WatsonConversationHelper helper = new WatsonConversationHelper("067f76d1-0265-4d3f-a5a2-7053719e6748", "0539e38e-c89f-49f5-a330-b7f3deabdc7e", "ihqqrz0esuU5");

            var res = helper.GetResponse("qualquer").GetAwaiter().GetResult();
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}