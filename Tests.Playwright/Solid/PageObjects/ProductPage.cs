using Azure;
using Microsoft.Playwright;

namespace Tests.Playwright.Solid.PageObjects
{
    internal class ProductPage(IPage page)
    {
        private IPage Page = page;


        public async Task GotoCheckout()
        {
            await Page.GetByRole(AriaRole.Link, new() { Name = "CHECKOUT" }).ClickAsync();
        }

        public async Task BacktoCatalog()
        {
            await Page.GetByRole(AriaRole.Link, new() { Name = "Back to event catalog" }).ClickAsync();
        }
    }
}