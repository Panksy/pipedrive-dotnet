using System;
using System.IO;
using System.Reflection;

namespace Pipedrive.Tests.Integration
{
    public static class Helper
    {
        public static Uri ApiUrl { get { return _apiUrl.Value; } }

        public static string ApiToken { get { return Environment.GetEnvironmentVariable("PIPEDRIVE_APITOKEN"); } }

        static readonly Lazy<Uri> _apiUrl = new Lazy<Uri>(() =>
        {
            string uri = Environment.GetEnvironmentVariable("PIPEDRIVE_URL");

            if (uri != null)
            {
                return new Uri($"https://{uri}.pipedrive.com");
            }

            return null;
        });

        public static IPipedriveClient GetAuthenticatedClient(bool useSecondUser = false)
        {
            Environment.SetEnvironmentVariable("PIPEDRIVE_APITOKEN", "be7d8965e9bb3300acbe2048be0c6b9a79e5938e ");
            Environment.SetEnvironmentVariable("PIPEDRIVE_URL", "snappetus");
            return new PipedriveClient(new ProductHeaderValue("PipedriveTests"), ApiUrl, ApiToken);
        }

        public static Stream LoadFixture(string fileName)
        {
            var key = "Pipedrive.Tests.Integration.Fixtures." + fileName;
            var stream = typeof(Helper).GetTypeInfo().Assembly.GetManifestResourceStream(key);
            if (stream == null)
            {
                throw new InvalidOperationException(
                    "The file '" + fileName + "' was not found as an embedded resource in the assembly. Failing the test...");
            }
            return stream;
        }
    }
}
