using Newtonsoft.Json;
using Pipedrive.Http;

namespace Pipedrive.Internal
{
    internal class JsonResponse<T>
    {
        public bool Success { get; set; }

        public T Data { get; set; }

		[JsonProperty("additional_data")]
		public AdditionalData AdditionalData { get; set; }
		public object Related_Objects { get; set; }

	}
}
