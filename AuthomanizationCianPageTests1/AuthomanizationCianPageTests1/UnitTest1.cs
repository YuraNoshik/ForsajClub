using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace AuthomanizationCianPageTests1
{
    public class Tests
    {
        private IWebDriver driver;

        private readonly string userLogin = "tester.testirovanie@bk.ru";
        private readonly string userPassword = "olegnelubitmenya";

        private readonly By enterBtn = By.XPath("/html/body/main/div[2]/div[1]/div[1]/div[2]/div[1]/button");
        private readonly By inputLog = By.XPath("//*[@class='input-0-2-71']");
        private readonly By inputPassw = By.XPath("//input[@name='password']");
        private readonly By enterBtn2 = By.XPath("//*[@class='inner-0-2-81 innerTextWrapper-0-2-82']");
        private readonly By enterBtn3 = By.XPath("//span[text()='Войти']");
        private readonly By eBtn = By.XPath("//a[@href='/compose/']");
        private readonly By inputWho = By.XPath("//input[@class='container--H9L5q size_s--3_M-_']");
        private readonly By inputThm = By.XPath("//input[@tabindex='400']");
        //private readonly By inputMessage = By.XPath("");
        private readonly By sendMessage = By.XPath("//span[text()='Отправить']");
        private readonly By sendMessage2 = By.XPath("//span[@class='inner-0-2-93 innerTextWrapper-0-2-94']");
        private readonly By crossBtn = By.XPath("//span[@title='Закрыть']");

        [SetUp]
        public void Setup()
        {

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(@"https://mail.ru/");
            //driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            Thread.Sleep(2000);

            var enter = driver.FindElement(enterBtn);
            enter.Click();

            Thread.Sleep(3000);

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//*[@class='ag-popup__frame__layout__iframe']")));

            var loginIn = driver.FindElement(inputLog);
            loginIn.SendKeys(userLogin);

            var enter2 = driver.FindElement(enterBtn2);
            enter2.Click();

            Thread.Sleep(2000);

            var passwordIn = driver.FindElement(inputPassw);
            passwordIn.SendKeys(userPassword);

            var enter3 = driver.FindElement(enterBtn3);
            enter3.Click();

            Thread.Sleep(2000);

            driver.SwitchTo().DefaultContent();

            Thread.Sleep(2000);

            var btn = driver.FindElement(eBtn);
            btn.Click();

            Thread.Sleep(3000);

            driver.FindElement(inputWho).SendKeys("tester.testirovanie@bk.ru");


            var thm = driver.FindElement(inputThm);
            thm.SendKeys("Тестовое сообщениие");

            var sendMsg = driver.FindElement(sendMessage);
            sendMsg.Click();

            Thread.Sleep(3000);

            var sendMsg2 = driver.FindElement(sendMessage2);
            sendMsg2.Click();

            Thread.Sleep(6000);

            var crossX = driver.FindElement(crossBtn);
            crossX.Click();
        }
    }
}