using Microsoft.Playwright;
using PlaywrightTests;

namespace Tests.Playwright.PageObjects
{
    public class CheckOutPage
    {
        private PlaywrightTestWithArtifact testContext;

        public CheckOutPage(PlaywrightTestWithArtifact testContext)
        {

            this.testContext = testContext;
        }

        public bool IsOrderPlaced()
        {
            return testContext.Page.GetByRole(AriaRole.Heading, new() { Name = "Thank you for your order!" }).IsVisibleAsync().Result;
        }
    }
}