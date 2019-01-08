using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Pipedrive.Internal;
using System;
using System.Collections.Generic;

namespace Pipedrive
{
	[JsonConverter(typeof(CustomFieldConverter))]
	public class DealFieldValueUpdate : IEntityWithCustomFields
	{
		public DealFieldValueUpdate() {
			CustomFields = new Dictionary<string, ICustomField>();
		}
		[JsonIgnore]
		public IDictionary<string, ICustomField> CustomFields { get; set; }
	}
}
