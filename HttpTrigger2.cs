using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace JNC.Function
{
    public static class HttpTrigger2
    {
        [FunctionName("HttpTrigger2")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            var heroes = new List<string>
            {
                "Anti-Mage",
                "Axe",
                "Bane",
                "Bloodseeker",
                "Crystal Maiden",
                "Drow Ranger",
                "Earthshaker",
                "Juggernaut",
                "Mirana",
                "Morphling"
            };

            var result = JsonConvert.SerializeObject(heroes);

            return new OkObjectResult(result);
        }
    }
}
