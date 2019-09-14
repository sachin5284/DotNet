using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Grpc.Core;
using H2H.Rpc.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using Tennis;

namespace H2H.Rpc.Services
{
    public class H2HService : Tennis.H2H.H2HBase
    {
        public override Task<H2HReply> Details(H2HRequest request, ServerCallContext context)
        {
            if (request.Player1 == null || request.Player2 == null)
            {
                return Task.FromResult(new H2HReply { Success = false });
            }

            var h2h = GetHeadToHead(request.Player1, request.Player2);
            if (h2h == null)
            {
                return Task.FromResult(new H2HReply { Success = false });
            }

            // Ensure order of player IDs match
            var w1 = string.Equals(h2h.Id1, request.Player1, StringComparison.InvariantCultureIgnoreCase)
                ? h2h.Record1 : h2h.Record2;
            var w2 = string.Equals(h2h.Id2, request.Player2, StringComparison.InvariantCultureIgnoreCase)
                ? h2h.Record2 : h2h.Record1;

            return Task.FromResult(new H2HReply
            {
                Won1 = (uint)w1,
                Won2 = (uint)w2
            });
        }

        public override Task<H2HReply> DetailsDemo(H2HRequest request, ServerCallContext context)
        {
            var rnd = new Random(DateTime.Now.Second);
            return Task.FromResult(new H2HReply
            {
                Won1 = (uint)rnd.Next(0, 10),
                Won2 = (uint)rnd.Next(0, 10)
            });
        }

        public override Task MultiDetails(H2HMultiRequest request, IServerStreamWriter<H2HMultiReply> responseStream, ServerCallContext context)
        {
            foreach (var opponent in request.Opponent)
            {
                // Grab raw data to return
                var h2h = GetHeadToHead(request.Player, opponent);

                // Fix data to return (ensure order of player IDs match)
                var item1 = new H2HItem();
                var item2 = new H2HItem();
                if (string.Equals(h2h.Id1, request.Player, StringComparison.InvariantCultureIgnoreCase))
                {
                    item1.Name = h2h.Id1;
                    item1.Won = (uint) h2h.Record1;
                    item2.Name = h2h.Id2;
                    item2.Won = (uint) h2h.Record2;
                }
                else
                {
                    item1.Name = h2h.Id2;
                    item1.Won = (uint) h2h.Record2;
                    item2.Name = h2h.Id1;
                    item2.Won = (uint)h2h.Record1;
                }

                var reply = new H2HMultiReply { Player1 = item1, Player2 = item2 };

                // Write back
                responseStream.WriteAsync(reply);
            }

            return Task.CompletedTask;
        }


        #region PRIVATE
        private static HeadToHeadSummary GetHeadToHead(string id1, string id2)
        {
            var p1 = id1.ToUpper();
            var p2 = id2.ToUpper();

            var url = $"http://ws1.crionetmedia.com/cerere/api/h2h?p1={p1}&p2={p2}";
            var client = new WebClient();
            var data = client.DownloadString(url);
            var h2h = JsonConvert.DeserializeObject<HeadToHeadSummary>(data);
            return h2h;
        }
        #endregion
    }
}
