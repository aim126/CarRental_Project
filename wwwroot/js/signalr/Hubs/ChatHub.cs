using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace SignaIRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage,user, message");
        }
    }
        public async SendMessage(string employee , string message)
        {
        await Clients.All.SendMessage("ReplyMessage,employee, message"); 
        }
}
