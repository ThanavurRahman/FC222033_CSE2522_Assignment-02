using NUnit.Framework;
using CSE2522_Assignment02.Base;
using CSE2522_Assignment02.Pages;

namespace CSE2522_Assignment02.Tests
{
    [TestFixture]
    public class ClientSideDelayTests : BaseTest
    {
        [Test, Description("TC003_1_ClientSideDelay_Verification")]
        public void VerifyClientSideDelay()
        {
            driver.Navigate().GoToUrl("https://uitestingplayground.com/clientdelay");

            ClientSideDelayPage page = new ClientSideDelayPage(driver);

            page.ClickTriggerButton();

            string result = page.WaitForResultText();

            Assert.That(result.Contains("Data calculated on the client side"), Is.True);
        }
    }
}
