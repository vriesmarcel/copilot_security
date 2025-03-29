using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using Tests.Playwright.HelperClasses;
namespace Tests.Playwright.Dry
{
    [TestFixture]
    public class SimpleTests : PageTest
    {
        public string StartPage = "https://globoticket-frontend-dpfbe7hxa6d2bdab.westeurope-01.azurewebsites.net/";


        [Test]
        public async Task BuyOneProduct()
        {
            //insert Generated code here
            await GotoHomepage();
            await SelectProduct("Artist pic 09/25/2025 John");
            await GotoCheckout();
            await Checkout();
        }

        [Test]
        public async Task BuyTwoProducts()
        {
            //insert Generated code here
            await GotoHomepage();
            await SelectProduct("Artist pic 12/25/2025 The");
            await BacktoCatalog();
            await SelectProduct("Artist pic 09/25/2025 John");
            await GotoCheckout();
            await Checkout();

        }

        [Test]
        public async Task SelectTreeTicketsAndRemoveOne()
        {
            //insert Generated code here
            await GotoHomepage();
            await SelectProduct("Artist pic 09/25/2025 John");
            await BacktoCatalog();
            await SelectProduct("Artist pic 12/25/2025 The", 3);
            await GotoCheckout();
            await Checkout();
        }

        /* here you find the methods extracted from the recordings, to make the test so called DRY */
        #region DRY Methods 
        private async Task GotoHomepage()
        {
            await Page.GotoAsync(StartPage);
        }

        private async Task Checkout()
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

        private async Task GotoCheckout()
        {
            await Page.GetByRole(AriaRole.Link, new() { Name = "CHECKOUT" }).ClickAsync();
        }

        private async Task SelectProduct(string productName, int numberOftickets = 1)
        {
            await Page.GetByRole(AriaRole.Row, new() { Name = productName }).GetByRole(AriaRole.Link).ClickAsync();
            await Page.GetByRole(AriaRole.Combobox).SelectOptionAsync(new[] { $"{numberOftickets}" });
            await Page.GetByRole(AriaRole.Button, new() { Name = "PLACE ORDER" }).ClickAsync();
        }
        private async Task BacktoCatalog()
        {
            await Page.GetByRole(AriaRole.Link, new() { Name = "Back to event catalog" }).ClickAsync();
        }
        #endregion
    }
}