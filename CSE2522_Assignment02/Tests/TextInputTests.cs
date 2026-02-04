using NUnit.Framework;
using CSE2522_Assignment02.Base;
using CSE2522_Assignment02.Pages;

namespace CSE2522_Assignment02.Tests
{
    [TestFixture]
    public class TextInputTests : BaseTest
    {
        [Test, Description("TC001_1_TextInput_Verification")]
        public void VerifyTextInput()
        {
            driver.Navigate().GoToUrl("https://uitestingplayground.com/textinput");

            TextInputPage page = new TextInputPage(driver);

            string input = "Hello";

            page.EnterText(input);
            page.ClickButton();

            Assert.That(page.GetButtonText(), Is.EqualTo(input));
        }
    }
}
