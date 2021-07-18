using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRDemoApplication.Abstract
{
    public interface IMessageClient
    {
        Task ReceiveMessage(string message);
        Task Clients(List<string> clients);
        Task UserJoined(string connectionId);
        Task UserLeaved(string connectionId);
    }
}
