using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR600ROSControlCore
{
    public interface IBridgeClient
    {
        Task DisconnectAsync();
        Task ConnectAsync(Uri uri);
    }
}
