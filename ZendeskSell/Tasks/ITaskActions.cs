using System.Threading.Tasks;
using ZendeskSell.Models;

namespace ZendeskSell.Tasks
{
    public interface ITaskActions
    {
        /// <summary>
        /// Creates a task with the information from the passed CreateTaskObject, for the account associated with the authorizationString and returns a json string.
        /// </summary>
        /// <param name="authorizationString"></param>
        /// <param name="task"></param>
        /// <returns></returns>
        Task<ZendeskSellObjectResponse<TaskRequest>> CreateAsync(TaskRequest task);
    }
}