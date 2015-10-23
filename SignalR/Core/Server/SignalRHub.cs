using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Express.ObjectMapper;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.AspNet.SignalR.Json;
using Newtonsoft.Json;
using SignalR.Core.Model;

namespace SignalR.Core
{
    [HubName("SignalRHub")]
    public class SignalRHub : Hub, ISharedHub
    {
        public override Task OnConnected()
        {
            WindowsEventLog.WriteInfoLog(string.Format("Client [{0}] connected. Confirming this user...",
                Context.ConnectionId));

            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            if (User.ContainsConnectionId(Context.ConnectionId))
            {
                var user = User.GetUserById(Context.ConnectionId);

                WindowsEventLog.WriteInfoLog(string.Format("{0} disconnected!\n", user.ToString()));

                user.Remove();
            }
            else
            {
                WindowsEventLog.WriteInfoLog(string.Format("The client by id [{0}] disconnected.\n",
                    Context.ConnectionId));
            }

            return base.OnDisconnected(stopCalled);
        }

        public override Task OnReconnected()
        {
            WindowsEventLog.WriteWarningLog(User.ContainsConnectionId(Context.ConnectionId)
                ? string.Format("[{0}] reconnected.\n", User.GetUserById(Context.ConnectionId))
                : string.Format("The client by id [{0}] reconnected.\n", Context.ConnectionId));

            return base.OnReconnected();
        }

        public IEnumerable<IUser> GetUsers()
        {
            var callerUser = User.GetUserById(Context.ConnectionId);

            if (callerUser != null &&
                String.Equals(callerUser.Category, "Administrators", StringComparison.CurrentCultureIgnoreCase))
            {
                return User.Users.Values.ToList();
            }

            return new List<IUser>();
        }

        public async Task<object> DynamicMethodRunner(string type, string method, string[] paramTypesAsembly,
            params object[] args)
        {
            object result = null;

            if (paramTypesAsembly.Length != args.Length)
            {
                string msg = "Arguments out or less than parameters types number!";
                WindowsEventLog.WriteErrorLog(msg);

                await CallCallerClientAsync("MessageShower", "Server DynamicMethodRunner", msg, "Error");
            }
            //
            // Create reference type to call that type methods
            //
            Type methodType = Type.GetType(type);
            //
            // Convert paramTypesAsembly as string array to type array
            //
            Type[] types = paramTypesAsembly.Select(Type.GetType).ToArray();
            //
            // Set JSON converted objects to real type objects 
            // for example, every numbers in JSON are Int64 but may be real type is Int16
            //
            object[] parameters = args.Select((t, i) => Convert.ChangeType(t, types[i])).ToArray();
            //
            // Call method by real type parameters
            //
            if (methodType != null)
            {
                var mi = methodType.GetMethod(method, types);
                result = mi.Invoke(null, parameters);
            }

            return result;
        }

        #region Implement ISharedHub

        #region Client Call Method Invokers

        public async Task CallAllClientsAsync(string method, params object[] args)
        {
            await Clients.All.Call(method, args);
        }

        public async Task CallOtherClientsAsync(string method, params object[] args)
        {
            await Clients.Others.Call(method, args);
        }

        public async Task CallCallerClientAsync(string method, params object[] args)
        {
            await Clients.Caller.Call(method, args);
        }

        public async Task CallClientAsync(string username, string method, params object[] args)
        {
            var user = User.GetUserByName(username);
            if (user != null)
            {
                await Clients.Client(user.ConnectionId).Call(method, args);
            }
        }

        public async Task CallClientsAsync(List<string> usernames, string method, params object[] args)
        {
            var clientIds = new List<string>();
            clientIds.AddRange(from username in usernames
                select User.GetUserByName(username)
                into user
                where user != null
                select user.ConnectionId);

            await Clients.Clients(clientIds).Call(method, args);
        }

        public async Task CallClientGroupsAsync(string[] groups, string method, params object[] args)
        {
            await Clients.Groups(groups).Call(method, args);
        }

        #endregion

        #region Client CallByType Method Invokers

        public async Task CallByTypeAllClientsAsync(string type, string method, string[] paramTypes,
            params object[] args)
        {
            await Clients.All.CallByType(type, method, paramTypes, args);
        }

        public async Task CallByTypeOtherClientsAsync(string type, string method, string[] paramTypes,
            params object[] args)
        {
            await Clients.Others.CallByType(type, method, paramTypes, args);
        }

        public async Task CallByTypeCallerClientAsync(string type, string method, string[] paramTypes,
            params object[] args)
        {
            await Clients.Caller.CallByType(type, method, paramTypes, args);
        }

        public async Task CallByTypeClientAsync(string username, string type, string method, string[] paramTypes,
            params object[] args)
        {
            var user = User.GetUserByName(username);
            if (user != null)
            {
                await Clients.Client(user.ConnectionId).CallByType(type, method, paramTypes, args);
            }
        }

        public async Task CallByTypeClientsAsync(List<string> usernames, string type, string method, string[] paramTypes,
            params object[] args)
        {
            var clientIds = new List<string>();
            clientIds.AddRange(from username in usernames
                select User.GetUserByName(username)
                into user
                where user != null
                select user.ConnectionId);

            await Clients.Clients(clientIds).CallByType(type, method, paramTypes, args);
        }

        public async Task CallByTypeClientGroupsAsync(string[] groups, string type, string method, string[] paramTypes,
            params object[] args)
        {
            await Clients.Groups(groups).CallByType(type, method, paramTypes, args);
        }

        #endregion

        public async Task<bool> UsernameVerificationAsync(User user)
        {
            if (User.ContainsUsername(user.Username)) // this user already is exist
            {
                WindowsEventLog.WriteFailureAuditLog(
                    Properties.Resources.M0001.Replace("#username", user.Username).Replace("#IP", user.IP) +
                    Environment.NewLine, 1);

                await
                    CallCallerClientAsync("OnRaiseLog",
                        Properties.Resources.ResourceManager.GetString("M0001",
                            CultureInfo.CreateSpecificCulture(user.Culture)));

                return false;
            }
            else
            {
                user.ConnectionId = Context.ConnectionId;
                User.Add(user);
                await
                    Groups.Add(Context.ConnectionId, string.IsNullOrEmpty(user.Category) ? "Undefined" : user.Category);
                WindowsEventLog.WriteSuccessAuditLog(
                    Properties.Resources.M0002.Replace("#username", user.Username).Replace("#IP", user.IP) +
                    Environment.NewLine, 2);
                return true;
            }
        }

        #endregion
    }
}