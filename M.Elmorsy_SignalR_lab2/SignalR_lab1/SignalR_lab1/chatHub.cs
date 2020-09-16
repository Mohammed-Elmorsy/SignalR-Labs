using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public void joinGroup(string groupName, string name)
        {
            Groups.Add(Context.ConnectionId, groupName);
            Clients.OthersInGroup(groupName).newMember(name, groupName);
        }

        public void sendGroup(string groupName,string name, string message)
        {
            Clients.Group(groupName).newGroupMessage(name, groupName, message);
        }

        public override Task OnConnected()
        {
            string txt = Context.ConnectionId;
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);
        }
    }
}