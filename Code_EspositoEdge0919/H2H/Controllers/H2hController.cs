using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using H2H.Application;
using H2H.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Tennis;

namespace H2H.Controllers
{
    public class H2HController : Controller
    {
        private readonly IHubContext<H2HHub> _h2hHubContext;
        public H2HController(IHubContext<H2HHub> h2hHubContext)
        {
            _h2hHubContext = h2hHubContext;
        }

        [HttpPost]
        public IActionResult Details(string p1, string p2, string sender)
        {
            // Call the RPC service
            const string host = "localhost";
            const int port = 50051;

            var serviceUrl = host + ":" + port;
            var channel = new Channel(serviceUrl, ChannelCredentials.Insecure);
            var client = new Tennis.H2H.H2HClient(channel);

            var request = new H2HRequest() {Player1 = p1, Player2 = p2};
            var response = sender == "detailsdemo" 
                ? client.DetailsDemo(request) 
                : client.Details(request);

            var model = new H2HViewModel {Player1 = p1, Player2 = p2, Won1 = response.Won1, Won2 = response.Won2};
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Multi(string connId, string p1, string p2, string sender)
        {
            // Call the RPC service
            const string host = "localhost";
            const int port = 50051;

            var serviceUrl = host + ":" + port;
            var channel = new Channel(serviceUrl, ChannelCredentials.Insecure);
            var client = new Tennis.H2H.H2HClient(channel);

            var request = new H2HMultiRequest() { Player = "F324" };
            request.Opponent.Add("W367");
            request.Opponent.AddRange(new[] { "D683", "F510" });

            var model = new H2HMultiViewModel();
            using (var response = client.MultiDetails(request))
            {
                while (await response.ResponseStream.MoveNext())
                {
                    var reply = response.ResponseStream.Current;
                    model.Matches.Add(new PlayerScore(reply.Player1.Name, reply.Player1.Won, reply.Player2.Name, reply.Player2.Won));  

                    // SignalR here
                    await _h2hHubContext.Clients.Client(connId).SendAsync("responseReceived",
                        reply.Player1.Name,
                        reply.Player1.Won,
                        reply.Player2.Name,
                        reply.Player2.Won);
                }
            }

            return View(model);
        }
    }
}
