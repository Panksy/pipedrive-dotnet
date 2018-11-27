using Newtonsoft.Json;
using Pipedrive.CustomFields;
using Pipedrive.Internal;
using System;
using System.Collections.Generic;

namespace Pipedrive
{
    [JsonConverter(typeof(CustomFieldConverter))]
    public class Pipeline 
    {
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url_title")]
        public string URLTitle { get; set; }

        [JsonProperty("order_nr")]
        public int OrderNr { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("update_time")]
        public DateTime? UpdateTime { get; set; }

        [JsonProperty("add_time")]
        public DateTime AddTime { get; set; }

        [JsonProperty("deal_probability")]
        public bool DealProbability { get; set; }

        [JsonProperty("selected")]
        public bool Selected { get; set; }


        public PipelineUpdate ToUpdate()
        {
            return new PipelineUpdate
            {
                Name = Name,
				OrderNr = OrderNr,
				DealProbability = DealProbability,
				Active = Active
            };
        }
    }
}
