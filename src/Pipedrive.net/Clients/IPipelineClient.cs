using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pipedrive
{
    /// <summary>
    /// A client for Pipedrive's Pipelines API.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://developers.pipedrive.com/docs/api/v1/#!/Pipelines">Pipelines API documentation</a> for more information.
    public interface IPipelinesClient
    {
        Task<IReadOnlyList<Pipeline>> GetAll();

        Task<Pipeline> Get(long id);

        Task<Pipeline> Create(NewPipeline data);

        Task<Pipeline> Edit(long id, PipelineUpdate data);

        Task Delete(long id);
    }
}
