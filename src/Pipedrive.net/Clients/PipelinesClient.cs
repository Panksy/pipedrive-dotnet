﻿using Pipedrive.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pipedrive
{
    /// <summary>
    /// A client for Pipedrive's Pipelines API.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://developers.pipedrive.com/docs/api/v1/#!/Pipelines">Pipelines API documentation</a> for more information.
    public class PipelinesClient : ApiClient, IPipelinesClient
    {
        /// <summary>
        /// Initializes a new Person API client.
        /// </summary>
        /// <param name="apiConnection">An API connection</param>
        public PipelinesClient(IApiConnection apiConnection) : base(apiConnection)
        {
        }

        public Task<IReadOnlyList<Pipeline>> GetAll()
        {
			return ApiConnection.GetAll<Pipeline>(ApiUrls.Pipelines());
        }

		public Task<Pipeline> Get(long id)
        {
            return ApiConnection.Get<Pipeline>(ApiUrls.Pipeline(id));
        }

        public Task<Pipeline> Create(NewPipeline data)
        {
            Ensure.ArgumentNotNull(data, nameof(data));

            return ApiConnection.Post<Pipeline>(ApiUrls.Pipelines(), data);
        }

        public Task<Pipeline> Edit(long id, PipelineUpdate data)
        {
            Ensure.ArgumentNotNull(data, nameof(data));

            return ApiConnection.Put<Pipeline>(ApiUrls.Pipeline(id), data);
        }

        public Task Delete(long id)
        {
            return ApiConnection.Delete(ApiUrls.Pipeline(id));
        }
    }
}
