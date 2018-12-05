﻿using Newtonsoft.Json;
using Pipedrive.Helpers;
using Pipedrive.Http;
using System;
using System.IO;
using System.Net.Http;

namespace Pipedrive.Internal
{
    /// <summary>
    ///     Responsible for serializing the request and response as JSON and
    ///     adding the proper JSON response header.
    /// </summary>
    public class JsonHttpPipeline
    {
        public JsonHttpPipeline()
        {
        }

        public void SerializeRequest(IRequest request)
        {
            Ensure.ArgumentNotNull(request, nameof(request));

            if (!request.Headers.ContainsKey("Accept"))
            {
                request.Headers["Accept"] = AcceptHeaders.Json;
            }

            if (request.Method == HttpMethod.Get || request.Body == null) return;
            if (request.Body is string || request.Body is Stream || request.Body is HttpContent) return;

            request.Body = JsonConvert.SerializeObject(request.Body, Formatting.None, new CustomFieldConverter());
        }

        public IApiResponse<T> DeserializeResponse<T>(IResponse response)
        {
            Ensure.ArgumentNotNull(response, nameof(response));

            if (response.ContentType != null && response.ContentType.Equals("application/json", StringComparison.Ordinal))
            {
                var body = response.Body as string;
                // simple json does not support the root node being empty. Will submit a pr but in the mean time....
                if (!string.IsNullOrEmpty(body) && body != "{}")
                {
                    T newBody = default(T);
					AdditionalData additionalInfo = new AdditionalData();

					if (body.StartsWith("{", StringComparison.Ordinal) || body.StartsWith("[", StringComparison.Ordinal))
                    {
                        var json = JsonConvert.DeserializeObject<JsonResponse<T>>(body);
                        newBody = json.Data;
						additionalInfo = json.AdditionalData;

					}

                    return new ApiResponse<T>(response, newBody, additionalInfo);
                }
            }
            return new ApiResponse<T>(response);
        }
    }
}
