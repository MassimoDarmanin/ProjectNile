using Microsoft.AspNetCore.Mvc;
using Orleans;
using System.Threading.Tasks;

namespace ProjectOrleans
{
    public class HelloWorldController : Controller
    {
        private readonly IClusterClient clusterClient;
        public HelloWorldController(IClusterClient clusterClient)
        {
            this.clusterClient = clusterClient;
        }

        [HttpGet("/hello/{name}")]
        public async Task<IActionResult> Hello(string name)
        {
            var result = await clusterClient.GetGrain<IHelloWorldGrain>("Mose").SayHelloToAsync(name);
            return Ok(result);
        }
    }
}
