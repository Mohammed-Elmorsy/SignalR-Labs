using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalR_lab1
{
    [HubName("chat")]
    public class chatHub : Hub
    {
        public void sendMessage(string name, string message)
        {
            Clients.All.newMessage(name, message);
        }

    }
}