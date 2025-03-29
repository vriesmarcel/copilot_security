using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;
using NUnit.Framework;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class RecordedTests : PageTest
{
    public override BrowserNewContextOptions ContextOptions()
    {
        return new()
        {
            Locale = "en-US",
            ColorScheme = ColorScheme.Light,
            RecordVideoDir = ".videos",
            IgnoreHTTPSErrors = true
        };
    }

    [Test]
    public async Task MyTest()
    {
        await Page.GotoAsync("https://localhost:7274");
        await Page.GetByRole(AriaRole.Row, new() { Name = "Artist pic 9/25/2025 John" }).GetByRole(AriaRole.Link).ClickAsync();
        await Page.GetByRole(AriaRole.Combobox).SelectOptionAsync(new[] { "4" });
        await Page.GetByRole(AriaRole.Button, new() { Name = "PLACE ORDER" }).ClickAsync();
        await Page.GetByRole(AriaRole.Link, new() { Name = "CHECKOUT" }).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Name" }).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Name" }).FillAsync("Marcel");
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Name" }).PressAsync("Tab");
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Email" }).FillAsync("m@m.com");
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Email" }).PressAsync("Tab");
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Address" }).FillAsync("a");
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Address" }).PressAsync("Tab");
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Town" }).FillAsync("b");
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Town" }).PressAsync("Tab");
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Postal Code" }).FillAsync("1213VB");
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Postal Code" }).PressAsync("Tab");
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Credit Card" }).FillAsync("1111222233334444");
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Credit Card" }).PressAsync("Tab");
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Expiry Date" }).FillAsync("12/25");
        await Page.GetByRole(AriaRole.Button, new() { Name = "SUBMIT ORDER" }).ClickAsync();
        await Page.GotoAsync("https://localhost:7274/Checkout/Thanks");
        await Page.GetByRole(AriaRole.Heading, new() { Name = "Thank you for your order!" }).ClickAsync();
        await Expect(Page.GetByRole(AriaRole.Heading, new() { Name = "Thank you for your order!" })).ToBeVisibleAsync();
    }
}
