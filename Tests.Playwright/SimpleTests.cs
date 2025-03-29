using DotLiquid;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using Tests.Playwright.PageObjects;
using Azure.Developer.MicrosoftPlaywrightTesting.NUnit;
using PlaywrightTests;
namespace Tests.Playwright
{
    [TestFixture] 
    public class SimpleTests : PlaywrightTestWithArtifact
    {
        public string StartPage = "https://globoticket-frontend-dpfbe7hxa6d2bdab.westeurope-01.azurewebsites.net/";


        [Test] 
        public void SimpleTest()
        {
            var homepage = System.Environment.GetEnvironmentVariable("homepage");
            if (!string.IsNullOrWhiteSpace(homepage))
                StartPage = homepage.Trim();

            var BuyticketResult = HomePage.GetHomePage(this, StartPage)
                .SelectTicket("John Egbert")
                .BuyTicket()
                .Checkout(new CustomerNico())
                .IsOrderPlaced();
            Assert.That(BuyticketResult);
        }
    }
}