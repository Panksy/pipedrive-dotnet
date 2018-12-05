using System;
using System.Collections.Generic;
using System.Text;

namespace Pipedrive.Http
{
	[Newtonsoft.Json.JsonObject(Title = "additional_data")]
	public class AdditionalData
	{
		public PaginationInfo Pagination { get; set; }
	}
}
