using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Security.Cryptography.X509Certificates;
using TestProject_for_selenium.Pages;

namespace TestProject_for_selenium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {

            //1.create a new instance of selenium Web Driver
            //IWebDriver driver = new ChromeDriver();
            //2.Navigate to the URL
            //  driver.Navigate().GoToUrl("https://www.google.com/");
            //2a.Maximize the browser window
            //  driver.Manage().Window.Maximize();
            //3.Find the element
            // IWebElement webElement = driver.FindElement(By.Name("q"));

            //4.Type in the element
            // webElement.SendKeys("ielts");

            //5.clcik on the element
            // webElement.SendKeys(Keys.Return);




        }
        [Test]
        public void EAWebSiteTest()
        {
           // IWebDriver driver = new ChromeDriver();
           // driver.Navigate().GoToUrl("https://parabank.parasoft.com/");
            //  IWebElement loginLink = driver.FindElement(By.LinkText("µÇÂ¼"));
            //click the login link
            // loginLink.Click();
            //find the userName text box

           // IWebElement txtUserName = driver.FindElement(By.Name("username"));
            //typing on the textusername
           // txtUserName.SendKeys("tingting");
            //find the password text box
           // IWebElement txtPassword = driver.FindElement(By.Name("password"));
            // typing in the txtPassword 
          //  txtPassword.SendKeys("lttC2474070");


            //Identify the login in button
            // IWebElement txtLogin = driver.FindElement(By.CssSelector("input.button"));

            //click the login in button
            // txtLogin.Submit();
            //SeleniumCustomMethods.Submit(driver, By.CssSelector("input.button"));



        }
        [Test]
        public void TestWithPom() {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/");
            //POM Initalization
            LoginPage loginpage = new LoginPage(driver);
            //
           // loginpage.ClickLogin();
            loginpage.Login("tingting", "lttC2474070");

        }
    }
}


