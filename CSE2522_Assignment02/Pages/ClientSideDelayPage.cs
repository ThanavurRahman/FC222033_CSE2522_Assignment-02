using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace CSE2522_Assignment02.Pages
{
    public class ClientSideDelayPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public ClientSideDelayPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }

        private IWebElement TriggerButton =>
            wait.Until(d => d.FindElement(By.Id("ajaxButton")));

        private IWebElement LoadingIndicator =>
            driver.FindElement(By.Id("spinner"));

        private IWebElement ResultBanner =>
            wait.Until(d => d.FindElement(By.Id("content")));

        public void ClickTriggerButton()
        {
            TriggerButton.Click();
        }

        public bool IsLoadingDisplayed()
        {
            return LoadingIndicator.Displayed;
        }

        public string WaitForResultText()
        {
            wait.Until(d => d.FindElement(By.Id("content")).Text.Length > 0);
            return ResultBanner.Text;
        }
    }
}
