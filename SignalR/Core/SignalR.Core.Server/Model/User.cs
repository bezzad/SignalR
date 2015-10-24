using System;
using System.Collections.Generic;
using System.Linq;

namespace SignalR.Core.Model
{
    public class User : IUser
    {
        #region Shared Properties

        public static int Count { get { return Users.Count; } }

        public static User Empty { get { return new User(); } }

        public static Dictionary<string, User> Users { get; set; }

        #endregion

        #region IUser Members

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

        #endregion

        #region Constructors

        static User()
        {
            Users = new Dictionary<string, User>();
        }

        #endregion

        #region Shared Methods

        public static User Add(string connId, string username, string password, string category, string domain, string systemUsername, string ip, string mac, string cultureName)
        {
            var us = new User()
            {
                ConnectionId = connId,
                Domain = domain,
                Category = category,
                Username = username.ToLower(),
                Password = password,
                SystemUsername = systemUsername,
                EntryTime = DateTime.Now,
                IP = ip,
                MAC = mac,
                Culture = cultureName
            };

            Users.Add(connId, us);

            return us;
        }

        public static User Add(IUser iUser)
        {
            var user = FromIUser(iUser);

            Users.Add(iUser.ConnectionId, user);

            return user;
        }

        public static User FromIUser(IUser iUser)
        {
            if (iUser == null) return null;

            User user = new User();
            foreach (var prop in typeof(IUser).GetProperties())
            {
                var userProp = typeof(User).GetProperty(prop.Name);
                userProp.SetValue(user, prop.GetValue(iUser));
            }

            return user;
        }

        public static bool RemoveById(string connId)
        {
            return Users.Remove(connId);
        }

        public static bool RemoveByName(string username)
        {
            try
            {
                var user = GetUserByName(username);

                if (user != null)
                    return RemoveById(user.ConnectionId);

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static User GetUserById(string connectionId)
        {
            return Users[connectionId];
        }

        public static User GetUserByName(string username)
        {
            var user = Users.Values.First(x => x.Username == username.ToLower());

            return user;
        }

        public static bool ContainsConnectionId(string id)
        {
            return Users.ContainsKey(id);
        }

        public static bool ContainsUsername(string name)
        {
            return Users.Values.Any(x => x.Username == name.ToLower());
        }

        #endregion

        #region Methods

        /// <summary>
        /// <para>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </para>
        /// <p>
        ///     Pattern: "Domain\SystemUsername (MachineName):     Name [ConnectionId]"
        /// </p>
        /// </summary>
        /// <returns>
        /// Return a string in this pattern: "Domain\SystemUsername (MachineName):     Name [ConnectionId]"
        /// </returns>
        public override string ToString()
        {
            var str = string.Format("{0}\\{1} (IP:{2}):\t [{3}]",
                Domain,
                SystemUsername,
                IP,
                Username);

            return str;
        }

        /// <summary>
        /// Removes this instance.
        /// </summary>
        /// <returns></returns>
        public bool Remove()
        {
            return RemoveById(ConnectionId);
        }

        #endregion
    }
}