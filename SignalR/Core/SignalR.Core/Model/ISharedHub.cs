using System.Collections.Generic;
using System.Threading.Tasks;

namespace SignalR.Core.Model
{
    public interface ISharedHub
    {

        #region Client Call Method Invokers

        Task CallAllClientsAsync(string method, params object[] args);

        Task CallOtherClientsAsync(string method, params object[] args);

        Task CallCallerClientAsync(string method, params object[] args);

        Task CallClientAsync(string username, string method, params object[] args);

        Task CallClientsAsync(List<string> usernames, string method, params object[] args);

        Task CallClientGroupsAsync(string[] groups, string method, params object[] args);

        #endregion

        #region Client CallByType Method Invokers

        Task CallByTypeAllClientsAsync(string type, string method, string[] paramTypes, params object[] args);

        Task CallByTypeOtherClientsAsync(string type, string method, string[] paramTypes, params object[] args);

        Task CallByTypeCallerClientAsync(string type, string method, string[] paramTypes, params object[] args);

        Task CallByTypeClientAsync(string username, string type, string method, string[] paramTypes, params object[] args);

        Task CallByTypeClientsAsync(List<string> usernames, string type, string method, string[] paramTypes, params object[] args);

        Task CallByTypeClientGroupsAsync(string[] groups, string type, string method, string[] paramTypes, params object[] args);

        #endregion
    }
}
