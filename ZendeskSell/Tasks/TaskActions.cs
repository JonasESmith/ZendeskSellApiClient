using System.Threading.Tasks;
using RestSharp;
using ZendeskSell.Models;

namespace ZendeskSell.Tasks
{
    public class TaskActions : ITaskActions
    {
        private RestClient _client;

        public TaskActions(RestClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Creates a task with the information from the passed CreateTaskObject, for the account associated with the authorizationString and returns a json string.
        /// </summary>
        /// <param name="authorizationString"></param>
        /// <param name="task"></param>
        /// <returns></returns>
        public async Task<ZendeskSellObjectResponse<TaskRequest>> CreateAsync(TaskRequest task)
        {
            var request = new RestRequest("tasks", Method.POST) { RequestFormat = DataFormat.Json };
            request.JsonSerializer = new RestSharpJsonNetSerializer();
            request.AddJsonBody(new ZendeskSellRequest<TaskRequest>(task));
            return (await _client.ExecutePostTaskAsync<ZendeskSellObjectResponse<TaskRequest>>(request)).Data;
        }
    }
}