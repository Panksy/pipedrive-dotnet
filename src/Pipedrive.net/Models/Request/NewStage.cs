using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Pipedrive
{
    public class NewStage
    {
        [JsonProperty("name")]
        public string Name { get; set; }

		[JsonProperty("pipeline_id")]
        public long PipelineId { get; set; }

      

        public NewStage(string name, long PipelineId)
        {
            this.Name = name;
			this.PipelineId = PipelineId;
        }
    }
}
