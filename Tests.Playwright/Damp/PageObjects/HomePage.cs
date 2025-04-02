using Azure;
using DotLiquid.Util;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Playwright.Solid.PageObjects
{
    internal class HomePage (IPage page)
    {
        IPage Page = page;
        public HomePage NavigateToHomePage(string startPage)
        {
            var page = Page.GotoAsync(startPage).Result;
            return new HomePage(Page);
        }

        public ProductPage SelectProduct(string productName, int numberOfTickets=1)
        {
            Page.GetByRole(AriaRole.Row, new() { Name = productName }).
                GetByRole(AriaRole.Link).ClickAsync().Wait();
            Page.GetByRole(AriaRole.Combobox).SelectOptionAsync(new[] { $"{numberOfTickets}" }).Wait();
            Page.GetByRole(AriaRole.Button, new() { Name = "PLACE ORDER" }).ClickAsync().Wait();
            return new ProductPage(Page);
        }
    }
}
