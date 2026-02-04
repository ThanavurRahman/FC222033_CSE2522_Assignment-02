using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace CSE2522_Assignment02.Pages
{
    public class AlertsPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public AlertsPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        private IWebElement AlertButton =>
            wait.Until(d => d.FindElement(By.Id("alertButton")));

        private IWebElement ConfirmButton =>
            wait.Until(d => d.FindElement(By.Id("confirmButton")));

        private IWebElement PromptButton =>
            wait.Until(d => d.FindElement(By.Id("promptButton")));

        public void ClickAlert()
        {
            AlertButton.Click();
        }

        public void ClickConfirm()
        {
            ConfirmButton.Click();
        }

        public void ClickPrompt()
        {
            PromptButton.Click();
        }

        public IAlert SwitchToAlert()
        {
            return wait.Until(d => d.SwitchTo().Alert());
        }
    }
}
