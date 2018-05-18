using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AR600ROSControlCore;
using Rosbridge.Client;

namespace FrundController
{
    public class FrundControllerClient: IBridgeClient
    {
        MessageDispatcher dispatcher;

        public async Task ConnectAsync(Uri uri)
        {
            dispatcher = new MessageDispatcher(new Socket(uri), new MessageSerializerV2_0());
            await dispatcher.StartAsync();
        }

        public async Task DisconnectAsync()
        {
            await dispatcher.StopAsync();
        }
    }
}
