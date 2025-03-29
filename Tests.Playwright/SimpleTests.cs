using NUnit.Framework;
using Tests.Playwright.HelperClasses;
namespace Tests.Playwright
{
    [TestFixture] 
    public class SimpleTests : PlaywrightTestWithArtifact
    {
        public string StartPage = "https://globoticket-frontend-dpfbe7hxa6d2bdab.westeurope-01.azurewebsites.net/";

        [Test] 
        public async Task BuyOneProduct()
        {
            //insert Generated code here
        }

        [Test]
        public async Task BuyTwoProducts()
        {
            //insert Generated code here
        }

        [Test]
        public async Task SelectTreeTicketsAndRemoveOne()
        {
            //insert Generated code here
        }
    }
}