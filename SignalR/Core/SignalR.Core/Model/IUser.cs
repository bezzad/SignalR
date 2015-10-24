using System;

namespace SignalR.Core.Model
{
    public interface IUser
    {
        string ConnectionId { get; set; }

        string Username { get; set; }

        string Password { get; set; }

        string Category { get; set; }

        string Domain { get; set; }

        string SystemUsername { get; set; }

        DateTime EntryTime { get; set; }

        string IP { get; set; }

        string MAC { get; set; }

        string Culture { get; set; }
    }
}

