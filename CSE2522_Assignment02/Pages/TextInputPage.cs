using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace CSE2522_Assignment02.Pages
{
    public class TextInputPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public TextInputPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        private IWebElement TextBox =>
            wait.Until(d => d.FindElement(By.Id("newButtonName")));

        private IWebElement Button =>
            wait.Until(d => d.FindElement(By.Id("updatingButton")));

        public void EnterText(string text)
        {
            TextBox.Clear();
            TextBox.SendKeys(text);
        }

        public void ClickButton()
        {
            Button.Click();
        }

        public string GetButtonText()
        {
            return Button.Text;
        }
    }
}
