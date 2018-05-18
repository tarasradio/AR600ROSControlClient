using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rosbridge.Client;

namespace AR600ROSControlCore
{
    public class ROSBridgeClient
    {
        public List<IBridgeClient> Clients { get; set; }

        public ROSBridgeClient()
        {
            Clients = new List<IBridgeClient>();
        }

        public async Task ConnectAsync(Uri uri)
        {
            foreach (var item in Clients)
                await item.ConnectAsync(uri);
        }

        public async Task DisconnectAsync()
        {
            foreach (var item in Clients)
                await item.DisconnectAsync();
        }
    }
}
