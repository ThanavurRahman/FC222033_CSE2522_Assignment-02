using NUnit.Framework;
using CSE2522_Assignment02.Base;
using CSE2522_Assignment02.Pages;

namespace CSE2522_Assignment02.Tests
{
    [TestFixture]
    public class SampleAppTests : BaseTest
    {
        [Test, Description("TC002_1_Verification_of_Sample_App_Page")]
        public void VerifySampleAppPage()
        {
            driver.Navigate().GoToUrl("https://uitestingplayground.com/sampleapp");

            SampleAppPage page = new SampleAppPage(driver);

            Assert.That(driver.PageSource.Contains("User Name"), Is.True);
            Assert.That(driver.PageSource.Contains("Password"), Is.True);
            Assert.That(driver.PageSource.Contains("Log In"), Is.True);
        }

        [Test, Description("TC002_2_Verification_of_Successful_Login")]
        public void VerifySuccessfulLogin()
        {
            driver.Navigate().GoToUrl("https://uitestingplayground.com/sampleapp");

            SampleAppPage page = new SampleAppPage(driver);

            page.Login("admin", "pwd");

            Assert.That(page.GetStatusMessage().Contains("Welcome"), Is.True);
        }

        [Test, Description("TC002_3_Verification_of_Unsuccessful_Login")]
        public void VerifyUnsuccessfulLogin()
        {
            driver.Navigate().GoToUrl("https://uitestingplayground.com/sampleapp");

            SampleAppPage page = new SampleAppPage(driver);

            page.Login("admin", "wrongpassword");

            Assert.That(page.GetStatusMessage().Contains("Invalid"), Is.True);
        }
    }
}
