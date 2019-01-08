using Pipedrive.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pipedrive
{
    /// <summary>
    /// A client for Pipedrive's Note API.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://developers.pipedrive.com/docs/api/v1/#!/Notes">Note API documentation</a> for more information.
    public class MailMessagesClient : ApiClient, IMailMessagesClient
    {
        /// <summary>
        /// Initializes a new Note API client.
        /// </summary>
        /// <param name="apiConnection">An API connection</param>
        public MailMessagesClient(IApiConnection apiConnection) : base(apiConnection)
        {
        }
    
        public Task<MailMessage> Get(long id)
        {
			var parameters = new Dictionary<string, string>();
			parameters.Add("include_body", "1");
			return ApiConnection.Get<MailMessage>(ApiUrls.MailMessage(id),parameters);
        }

   
    }
}
