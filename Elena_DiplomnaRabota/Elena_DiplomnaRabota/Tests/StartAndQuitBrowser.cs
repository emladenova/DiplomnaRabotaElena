using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace Elena_DiplomnaRabota.Tests
{
    public class StartAndQuitBrowser
    {
        protected IWebDriver driver;
        [SetUp]

        public void StartBrowser()

        {

            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            Data.StartBrowserAndGoToUrl(driver);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            Thread.Sleep(3000);
          

         

        }


        [TearDown]
        public void TearDownBrowser()
        {

            driver.Dispose();
        }
    }
}
