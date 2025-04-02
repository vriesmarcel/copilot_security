using Azure;
using Microsoft.Playwright;

namespace Tests.Playwright.Solid.PageObjects
{
    internal class CheckoutPage(IPage page)
    {
        private IPage Page = page;



        public OrderConfirmationPage Checkout()
        {
            Page.GetByRole(AriaRole.Textbox, new() { Name = "Name" }).FillAsync("Marcel de Vries").Wait();
            Page.GetByRole(AriaRole.Textbox, new() { Name = "Email" }).FillAsync("vriesmarcel@hotmail.com").Wait();
            Page.GetByRole(AriaRole.Textbox, new() { Name = "Address" }).FillAsync("Kerkhofweg 12").Wait();
            Page.GetByRole(AriaRole.Textbox, new() { Name = "Town" }).FillAsync("Warnsveld").Wait();
            Page.GetByRole(AriaRole.Textbox, new() { Name = "Postal Code" }).FillAsync("7231RJ").Wait();
            Page.GetByRole(AriaRole.Textbox, new() { Name = "Credit Card" }).FillAsync("1111222233334444").Wait();
            Page.GetByRole(AriaRole.Textbox, new() { Name = "Expiry Date" }).FillAsync("12/27").Wait();
            Page.GetByRole(AriaRole.Button, new() { Name = "SUBMIT ORDER" }).ClickAsync().Wait();
            return new OrderConfirmationPage(Page);
        }
    }
}