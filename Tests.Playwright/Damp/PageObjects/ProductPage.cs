using Azure;
using Microsoft.Playwright;

namespace Tests.Playwright.Solid.PageObjects
{
    internal class ProductPage(IPage page)
    {
        private IPage Page = page;


        public CheckoutPage GotoCheckout()
        {
            Page.GetByRole(AriaRole.Link, new() { Name = "CHECKOUT" }).ClickAsync().Wait();
            return new CheckoutPage(Page);
        }

        public HomePage BacktoCatalog()
        {
            Page.GetByRole(AriaRole.Link, new() { Name = "Back to event catalog" }).ClickAsync().Wait();
            return new HomePage(Page);
        }
    }
}