using System;
using System.Threading.Tasks;
using Xunit;

namespace Pipedrive.Tests.Integration.Clients
{
    public class RecentsClientTests
    {
        public class TheGetDealsMethod
        {
            [IntegrationTest]
            public async Task CanRetrieveDeals()
            {
                var pipedrive = Helper.GetAuthenticatedClient();
                var sinceWhen = new DateTime(2018,01,01);
                var deals = await pipedrive.Recents.GetDealRecents(sinceWhen);

                Assert.True(deals.Count >= 1);
                Assert.True(deals[0].Object=="deal");
                var deal = (SimpleCustomDeal)deals[0].Data;

                Assert.True(!string.IsNullOrEmpty(deal.Title));
            }
        }

        public class TheGetActivitiesMethod
        {
            [IntegrationTest]
            public async Task CanRetrieveActivities()
            {
                var pipedrive = Helper.GetAuthenticatedClient();
                var sinceWhen = new DateTime(2018, 01, 01);
                var recentsList = await pipedrive.Recents.GetActivityRecents(sinceWhen);

                Assert.True(recentsList.Count >= 1);
                Assert.True(recentsList[0].Object == "activity");
                var a = (Activity)recentsList[0].Data;

                Assert.True(!string.IsNullOrEmpty(a.Subject));
            }
        }

    }
}
