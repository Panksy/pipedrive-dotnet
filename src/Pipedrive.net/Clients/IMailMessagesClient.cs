using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pipedrive
{
    /// <summary>
    /// A client for Pipedrive's Note API.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://developers.pipedrive.com/docs/api/v1/#!/Notes">Note API documentation</a> for more information.
    public interface IMailMessagesClient
	{
        Task<MailMessage> Get(long id);

    }
}
