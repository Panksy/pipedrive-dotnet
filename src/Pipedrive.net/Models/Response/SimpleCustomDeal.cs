using Newtonsoft.Json;
using Pipedrive.Internal;
using System.Collections.Generic;

namespace Pipedrive
{
	[JsonConverter(typeof(CustomFieldConverter))]
	public class SimpleCustomDeal : IEntityWithCustomFields, IRecentsEntity
	{
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

		[JsonProperty("stage_id")]
		public long StageId { get; set; }

		[JsonProperty("user_id")]
        public long UserId { get; set; }

        [JsonProperty("visible_to")]
        public Visibility VisibleTo { get; set; }

        [JsonProperty("status")]
        public DealStatus Status { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("person_name")]
        public string PersonName { get; set; }

        [JsonProperty("person_id")]
        public long? PersonId { get; set; }

        [JsonProperty("org_name")]
        public string OrganizationName { get; set; }

        [JsonProperty("owner_name")]
        public string OwnerName { get; set; }       

        [JsonProperty("org_id")]
        public long? OrganizationId { get; set; }

        [JsonProperty("formatted_value")]
        public string FormattedValue { get; set; }

		[JsonIgnore]
		public IDictionary<string, ICustomField> CustomFields { get; set; }

	}
}
