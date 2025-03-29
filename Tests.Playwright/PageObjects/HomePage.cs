using Microsoft.Playwright;
using PlaywrightTests;
using System.Xml.Linq;

namespace Tests.Playwright.PageObjects
{
    internal class HomePage
    {
        PlaywrightTestWithArtifact testContext;
        public static HomePage GetHomePage(PlaywrightTestWithArtifact testContext, string homepageurl)
        {
            testContext.Page.GotoAsync(homepageurl).Wait();
            return new HomePage(testContext);
        }

        protected HomePage(PlaywrightTestWithArtifact testContext) {

            this.testContext = testContext;
        }
        public TicketDetailPage SelectTicket(string concertName)
        {
            var element = this.testContext.Page.GetByRole(AriaRole.Row)
                .Filter(new() { HasText = concertName });
            element.GetByRole(AriaRole.Cell, new() { Name = "PURCHASE DETAILS" }).ClickAsync().Wait();

            return new TicketDetailPage(testContext);
        }
    }
}