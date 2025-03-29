using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using Tests.Playwright.HelperClasses;
namespace Tests.Playwright
{
    [TestFixture] 
    public class SimpleTests : PageTest
    {
        public string StartPage = "https://globoticket-frontend-dpfbe7hxa6d2bdab.westeurope-01.azurewebsites.net/";

        [Test] 
        public async Task BuyOneProduct()
        {
            //insert Generated code here
            await Page.GotoAsync("https://globoticket-frontend-dpfbe7hxa6d2bdab.westeurope-01.azurewebsites.net/");
            await Page.GetByRole(AriaRole.Row, new() { Name = "Artist pic 12/25/2025 The" }).GetByRole(AriaRole.Link).ClickAsync();
            await Page.GetByRole(AriaRole.Button, new() { Name = "PLACE ORDER" }).ClickAsync();
            await Page.GetByRole(AriaRole.Link, new() { Name = "CHECKOUT" }).ClickAsync();
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Name" }).ClickAsync();
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Name" }).FillAsync("Marcel de Vries");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Name" }).PressAsync("Tab");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Email" }).FillAsync("vriesmarcel@hotmail.com");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Email" }).PressAsync("Tab");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Address" }).FillAsync("Kerkhofweg 12");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Address" }).PressAsync("Tab");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Town" }).FillAsync("Warnsveld");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Town" }).PressAsync("Tab");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Postal Code" }).FillAsync("7231RJ");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Postal Code" }).PressAsync("Tab");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Credit Card" }).FillAsync("1111222233334444");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Credit Card" }).PressAsync("Tab");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Expiry Date" }).FillAsync("12/26");
            await Page.GetByRole(AriaRole.Button, new() { Name = "SUBMIT ORDER" }).ClickAsync();
        }

        [Test]
        public async Task BuyTwoProducts()
        {
            //insert Generated code here
            await Page.GotoAsync("https://globoticket-frontend-dpfbe7hxa6d2bdab.westeurope-01.azurewebsites.net/");
            await Page.GetByRole(AriaRole.Row, new() { Name = "Artist pic 12/25/2025 The" }).GetByRole(AriaRole.Link).ClickAsync();
            await Page.GetByRole(AriaRole.Button, new() { Name = "PLACE ORDER" }).ClickAsync();
            await Page.GetByRole(AriaRole.Link, new() { Name = "Back to event catalog" }).ClickAsync();
            await Page.GetByRole(AriaRole.Row, new() { Name = "Artist pic 09/25/2025 John" }).GetByRole(AriaRole.Link).ClickAsync();
            await Page.GetByRole(AriaRole.Button, new() { Name = "PLACE ORDER" }).ClickAsync();
            await Page.GetByRole(AriaRole.Link, new() { Name = "CHECKOUT" }).ClickAsync();
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Name" }).ClickAsync();
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Name" }).FillAsync("Marcel de Vries");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Name" }).PressAsync("Tab");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Email" }).FillAsync("vriesmarcel@hotmail.com");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Email" }).PressAsync("Tab");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Address" }).FillAsync("Kerkhofweg 12");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Address" }).PressAsync("Tab");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Town" }).FillAsync("7231RJ");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Town" }).PressAsync("Tab");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Town" }).DblClickAsync();
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Town" }).PressAsync("ControlOrMeta+x");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Town" }).FillAsync("Warnsveld");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Town" }).PressAsync("Tab");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Postal Code" }).PressAsync("ControlOrMeta+c");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Postal Code" }).FillAsync("7231RJ");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Postal Code" }).PressAsync("Tab");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Credit Card" }).FillAsync("1111222233334444");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Credit Card" }).PressAsync("Tab");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Expiry Date" }).FillAsync("12/27");
            await Page.GetByRole(AriaRole.Button, new() { Name = "SUBMIT ORDER" }).ClickAsync();

        }

        [Test]
        public async Task SelectTreeTicketsAndRemoveOne()
        {
            //insert Generated code here
            await Page.GotoAsync("https://globoticket-frontend-dpfbe7hxa6d2bdab.westeurope-01.azurewebsites.net/");
            await Page.GetByRole(AriaRole.Row, new() { Name = "Artist pic 09/25/2025 John" }).GetByRole(AriaRole.Link).ClickAsync();
            await Page.GetByRole(AriaRole.Button, new() { Name = "PLACE ORDER" }).ClickAsync();
            await Page.GetByRole(AriaRole.Link, new() { Name = "Back to event catalog" }).ClickAsync();
            await Page.GetByRole(AriaRole.Row, new() { Name = "Artist pic 12/25/2025 The" }).GetByRole(AriaRole.Link).ClickAsync();
            await Page.GetByRole(AriaRole.Combobox).SelectOptionAsync(new[] { "3" });
            await Page.GetByRole(AriaRole.Button, new() { Name = "PLACE ORDER" }).ClickAsync();
            await Page.Locator("#z1__Quantity").SelectOptionAsync(new[] { "2" });
            await Page.GetByRole(AriaRole.Cell, new() { Name = "2 Update" }).GetByRole(AriaRole.Button).ClickAsync();
            await Page.GetByRole(AriaRole.Link, new() { Name = "CHECKOUT" }).ClickAsync();
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Name" }).ClickAsync();
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Name" }).FillAsync("Marcel de Vries");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Name" }).PressAsync("Tab");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Email" }).FillAsync("vriesmarcel@hotmail.com");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Email" }).PressAsync("Tab");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Address" }).FillAsync("Kerkhofweg 12");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Address" }).PressAsync("Tab");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Town" }).FillAsync("Warnsveld");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Town" }).PressAsync("Tab");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Postal Code" }).FillAsync("1213VB");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Postal Code" }).PressAsync("Tab");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Credit Card" }).FillAsync("1111222233334444");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Credit Card" }).PressAsync("Tab");
            await Page.GetByRole(AriaRole.Textbox, new() { Name = "Expiry Date" }).FillAsync("2/28");
            await Page.GetByRole(AriaRole.Button, new() { Name = "SUBMIT ORDER" }).ClickAsync();
        }
    }
}