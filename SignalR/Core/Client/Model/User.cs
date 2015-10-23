using System;

namespace SignalR.Core.Model
{
    public class User : Model, IUser
    {
        public string ConnectionId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Category { get; set; }
    
        public string Domain { get; set; }
    
        public string SystemUsername { get; set; }
    
        public DateTime EntryTime { get; set; }
    
        public string IP { get; set; }
    
        public string MAC { get; set; }

        public string Culture { get; set; }
    
    }
}

