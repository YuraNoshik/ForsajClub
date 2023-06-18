using NUnit.Framework;
using OpenQA.Selenium;

namespace AuthomanizationCianPageTests_
{
    public class Tests
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://spb.cian.ru");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [TearDown]
        public void TearDown()
        {

        }
    }
}