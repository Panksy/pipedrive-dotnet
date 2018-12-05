using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pipedrive
{
	[JsonObject(Title = "pagination")]
	public class PaginationInfo
	{
		public int Start { get; set; }
		public int Limit { get; set;  }

		[JsonProperty("more_items_in_collection")]
		public bool MoreItemsInCollection { get; set; }

		[JsonProperty("next_start")]
		public int NextStart { get; set; }
	}
}
