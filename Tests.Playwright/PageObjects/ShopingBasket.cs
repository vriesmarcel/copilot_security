using Microsoft.Playwright;
using PlaywrightTests;

namespace Tests.Playwright.PageObjects
{
    internal class ShopingBasket
    {
    
        private PlaywrightTestWithArtifact testContext;

        public ShopingBasket(PlaywrightTestWithArtifact testContext)
        {

            this.testContext = testContext;
        }

        public CheckOutPage Checkout(CustomerNico customer)
        {
            testContext.Page.Locator("id=Name").FillAsync(customer.name).Wait();
            testContext.Page.Locator("id=Address").FillAsync(customer.street).Wait();
            testContext.Page.Locator("id=Town").FillAsync(customer.town).Wait();
            testContext.Page.Locator("id=PostalCode").FillAsync(customer.postalcode).Wait();
            testContext.Page.Locator("id=CreditCardDate").FillAsync(customer.expdate).Wait();
            testContext.Page.Locator("id=Email").FillAsync(customer.email).Wait();
            testContext.Page.Locator("id=CreditCard").FillAsync(customer.cc).Wait();

            var button = testContext.Page.GetByRole(AriaRole.Button, new() { Name = "SUBMIT ORDER" });
            button.ClickAsync().Wait();
            return new CheckOutPage(testContext);
        }
    }
}