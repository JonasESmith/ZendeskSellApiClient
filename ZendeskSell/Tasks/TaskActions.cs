using RestSharp;

namespace Zendesk.Tasks
{
    public class TaskActions : ITaskActions
    {
        private RestClient _client;

        public TaskActions(RestClient client)
        {
            _client = client;
        }
    }
}