using Newtonsoft.Json;

namespace Pipedrive
{
	public class DealMerge
	{
		[JsonProperty("merge_with_id")]
		public long MergeWithId { get; set; }

	}
}
