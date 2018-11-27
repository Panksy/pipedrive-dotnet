using System.Collections.Generic;

namespace Pipedrive
{
    public class StageFilters
    {
        public static StageFilters None
        {
            get { return new StageFilters(); }
        }

        public int? PipelineId { get; set; }


        /// <summary>
        /// Get the query parameters that will be appending onto the search
        /// </summary>
        public IDictionary<string, string> Parameters
        {
            get
            {
                var d = new Dictionary<string, string>();
                if (PipelineId.HasValue)
                {
                    d.Add("pipeline_id", PipelineId.Value.ToString());
                }
                return d;
            }
        }
    }
}
