using Azure;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using Tests.Playwright.HelperClasses;
using Tests.Playwright.Solid.PageObjects;
namespace Tests.Playwright
{
    [TestFixture]
    public class SimpleTests : PageTest
    {
        public string StartPage = "https://globoticket-frontend-dpfbe7hxa6d2bdab.westeurope-01.azurewebsites.net/";


        [Test]
        public void BuyOneProduct()
        {
            bool istrue = new HomePage(Page)
                .NavigateToHomePage(StartPage)
                .SelectProduct("John Egbert Live")
                .GotoCheckout()
                .Checkout()
                .IsOrderConfirmed();

            Assert.That(istrue);
        }

        [Test]
        public void BuyTwoProducts()
        {
            //insert Generated code here


            bool istrue = new HomePage(Page)
              .NavigateToHomePage(StartPage)
              .SelectProduct("John Egbert Live")
              .BacktoCatalog()
              .SelectProduct("The State of Affairs")
              .GotoCheckout()
              .Checkout()
              .IsOrderConfirmed();

            Assert.That(istrue);
        }


        [Test]
        public void SelectTreeTicketsAndRemoveOne()
        {
            //insert Generated code here
            bool istrue = new HomePage(Page)
                .NavigateToHomePage(StartPage)
                .SelectProduct("John Egbert Live")
                .BacktoCatalog()
                .SelectProduct("The State of Affairs", 3)
                .GotoCheckout()
                .Checkout()
                .IsOrderConfirmed();
        }
    }

}