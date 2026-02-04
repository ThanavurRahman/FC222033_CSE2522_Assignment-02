using NUnit.Framework;
using CSE2522_Assignment02.Base;
using CSE2522_Assignment02.Pages;

namespace CSE2522_Assignment02.Tests
{
    [TestFixture]
    public class AlertsTests : BaseTest
    {
        [Test, Description("TC004_1_Verification_of_Alerts_Page")]
        public void VerifyAlertsPage()
        {
            driver.Navigate().GoToUrl("https://uitestingplayground.com/alerts");

            AlertsPage page = new AlertsPage(driver);

            Assert.That(driver.PageSource.Contains("Alert"), Is.True);
            Assert.That(driver.PageSource.Contains("Confirm"), Is.True);
            Assert.That(driver.PageSource.Contains("Prompt"), Is.True);
        }

        [Test, Description("TC004_2_Verification_of_Alert_Text")]
        public void VerifySimpleAlert()
        {
            driver.Navigate().GoToUrl("https://uitestingplayground.com/alerts");

            AlertsPage page = new AlertsPage(driver);

            page.ClickAlert();

            var alert = page.SwitchToAlert();

            Assert.That(alert.Text.Contains("Today is a working day"), Is.True);

            alert.Accept();
        }

        [Test, Description("TC004_3_Verification_of_Confirm_Alert")]
        public void VerifyConfirmAlert()
        {
            driver.Navigate().GoToUrl("https://uitestingplayground.com/alerts");

            AlertsPage page = new AlertsPage(driver);

            page.ClickConfirm();

            var alert = page.SwitchToAlert();
            Assert.That(alert.Text.Contains("Do you agree"), Is.True);
            alert.Accept();

            var secondAlert = page.SwitchToAlert();
            Assert.That(secondAlert.Text.Contains("Yes"), Is.True);
            secondAlert.Accept();
        }

        [Test, Description("TC004_4_Verification_of_Prompt_Alert")]
        public void VerifyPromptAlert()
        {
            driver.Navigate().GoToUrl("https://uitestingplayground.com/alerts");

            AlertsPage page = new AlertsPage(driver);

            page.ClickPrompt();

            var alert = page.SwitchToAlert();
            string input = "Hello";
            alert.SendKeys(input);
            alert.Accept();

            var resultAlert = page.SwitchToAlert();
            Assert.That(resultAlert.Text.Contains(input), Is.True);
            resultAlert.Accept();
        }
    }
}
