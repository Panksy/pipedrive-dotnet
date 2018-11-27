using Newtonsoft.Json;
using System.Collections.Generic;

namespace Pipedrive
{
    public class StageUpdate
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("deal_probability")]
        public int DealProbability { get; set; }

        [JsonProperty("order_nr")]
        public int OrderNr { get; set; }

        [JsonProperty("active_flag")]
        public bool ActiveFlag { get; set; }

    }
}
