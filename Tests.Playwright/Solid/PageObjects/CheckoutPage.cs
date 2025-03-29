using Azure;
using Microsoft.Playwright;

namespace Tests.Playwright.Solid.PageObjects
{
    internal class CheckoutPage(IPage page)
    {
        private IPage Page = page;



        public async Task Checkout()
        {
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Name" }).FillAsync("Marcel de Vries");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Email" }).FillAsync("vriesmarcel@hotmail.com");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Address" }).FillAsync("Kerkhofweg 12");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Town" }).FillAsync("Warnsveld");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Postal Code" }).FillAsync("7231RJ");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Credit Card" }).FillAsync("1111222233334444");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Expiry Date" }).FillAsync("12/27");
            await Page.GetByRole(AriaRole.Button, new() { Name = "SUBMIT ORDER" }).ClickAsync();
        }
    }
}