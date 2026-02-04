using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace CSE2522_Assignment02.Base
{
    public class BaseTest
    {
        protected IWebDriver driver = null!;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();

            options.AddArgument("--ignore-certificate-errors");
            options.AddArgument("--allow-insecure-localhost");
            options.AddArgument("--disable-web-security");
            options.AddArgument("--disable-site-isolation-trials");
            options.AddArgument("--test-type");

            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
        }


        [TearDown]
        public void TearDown()
        {
            if (driver is IDisposable disposable)
            {
                disposable.Dispose();
            }
        }
    }
}
