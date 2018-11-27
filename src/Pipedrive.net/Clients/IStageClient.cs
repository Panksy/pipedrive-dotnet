using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pipedrive
{
    /// <summary>
    /// A client for Pipedrive's Stages API.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://developers.pipedrive.com/docs/api/v1/#!/Stages">Stages API documentation</a> for more information.
    public interface IStagesClient
    {
        Task<IReadOnlyList<Stage>> GetAll(StageFilters stageFilters);

        Task<Stage> Get(long id);

        Task<Stage> Create(NewStage data);

        Task<Stage> Edit(long id, StageUpdate data);

        Task Delete(long id);
    }
}
