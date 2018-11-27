using Newtonsoft.Json;
using Pipedrive.CustomFields;
using Pipedrive.Internal;
using System;
using System.Collections.Generic;

namespace Pipedrive
{

    public class Stage 
    {
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pipeline_name")]
        public string PipelineName { get; set; }

        [JsonProperty("pipeline_id")]
		public long PipelineId { get; set; }

        [JsonProperty("order_nr")]
        public int OrderNr { get; set; }

        [JsonProperty("active_flag")]
        public bool ActiveFlag { get; set; }

        [JsonProperty("update_time")]
        public DateTime? UpdateTime { get; set; }

        [JsonProperty("add_time")]
        public DateTime AddTime { get; set; }

        [JsonProperty("deal_probability")]
        public int DealProbability { get; set; }



        public StageUpdate ToUpdate()
        {
            return new StageUpdate
            {
                Name = Name,
				OrderNr = OrderNr,
				DealProbability = DealProbability,
				ActiveFlag = ActiveFlag
            };
        }
    }
}
