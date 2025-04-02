using Microsoft.Playwright;

namespace Tests.Playwright.Solid.PageObjects
{
    internal class OrderConfirmationPage(IPage page)
    {
        IPage Page = page;

        public bool IsOrderConfirmed()
        {
            var heading = Page.GetByRole(AriaRole.Heading, new() { Name = "Thank you for your order!" });;
            return  heading.IsVisibleAsync().Result;
                
        }
    }
}