using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace CSE2522_Assignment02.Pages
{
    public class SampleAppPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public SampleAppPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        private IWebElement UserName =>
            wait.Until(d => d.FindElement(By.Name("UserName")));

        private IWebElement Password =>
            wait.Until(d => d.FindElement(By.Name("Password")));

        private IWebElement LoginButton =>
            wait.Until(d => d.FindElement(By.Id("login")));

        private IWebElement StatusLabel =>
            wait.Until(d => d.FindElement(By.Id("loginstatus")));

        public void Login(string user, string pass)
        {
            UserName.Clear();
            UserName.SendKeys(user);

            Password.Clear();
            Password.SendKeys(pass);

            LoginButton.Click();
        }

        public string GetStatusMessage()
        {
            return StatusLabel.Text;
        }
    }
}
