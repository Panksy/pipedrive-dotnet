using Pipedrive.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pipedrive
{
    /// <summary>
    /// A client for Pipedrive's Stage API.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://developers.pipedrive.com/docs/api/v1/#!/Stages">Stages API documentation</a> for more information.
    public class StagesClient : ApiClient, IStagesClient
    {
        /// <summary>
        /// Initializes a new Stages API client.
        /// </summary>
        /// <param name="apiConnection">An API connection</param>
        public StagesClient(IApiConnection apiConnection) : base(apiConnection)
        {
        }

        public Task<IReadOnlyList<Stage>> GetAll()
        {
           
            return ApiConnection.GetAll<Stage>(ApiUrls.Stages());
        }

        public Task<IReadOnlyList<Stage>> GetAllForPipelineId(long pipelineId)
        {
			var filters = new StageFilters(){ 
				PipelineId = pipelineId
			};
            var parameters = filters.Parameters;

            return ApiConnection.GetAll<Stage>(ApiUrls.Stages(), parameters);
        }

 

        public Task<Stage> Get(long id)
        {
            return ApiConnection.Get<Stage>(ApiUrls.Stage(id));
        }

        public Task<Stage> Create(NewStage data)
        {
            Ensure.ArgumentNotNull(data, nameof(data));

            return ApiConnection.Post<Stage>(ApiUrls.Stages(), data);
        }

        public Task<Stage> Edit(long id, StageUpdate data)
        {
            Ensure.ArgumentNotNull(data, nameof(data));

            return ApiConnection.Put<Stage>(ApiUrls.Stage(id), data);
        }

        public Task Delete(long id)
        {
            return ApiConnection.Delete(ApiUrls.Stage(id));
        }
    }
}
