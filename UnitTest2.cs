using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;



namespace TestProject_for_selenium
{


    public class Test2
    {
        [SetUp]
        public void Setup()
        {


        }

        [Test]
        public void InteractWebSiteTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/");
            //  IWebElement loginLink = driver.FindElement(By.LinkText("登录"));
            //click the login link
            // loginLink.Click();
            //find the userName text box

            IWebElement txtUserName = driver.FindElement(By.Name("username"));
            //typing on the textusername
            txtUserName.SendKeys("tingting");
            //find the password text box
            //IWebElement txtPassword = driver.FindElement(By.Name("password"));
            // typing in the txtPassword 
            // txtPassword.SendKeys("lttC2474070");
            SeleniumCustomMethods.EnterText(driver, By.Name("password"), "lttC2474070");


            //Identify the login in button
            var  txtLogin = driver.FindElement(By.CssSelector("input.button"));


            //click the login in button
            txtLogin.Submit();

            // 使用 By.LinkText 定位并点击链接
            IWebElement adminPageLink = driver.FindElement(By.LinkText("Admin Page"));
            adminPageLink.Click();
            //SelectElement selectElement = new SelectElement(driver.FindElement(By.Id("loanProvider")));
            //selectElement.SelectByValue("jms");
            //多选
            //SelectElement multiSelect = new SelectElement(driver.FindElement(By.Id("loanProvider")));
            //multiSelect.SelectByValue("jms");
            //multiSelect.SelectByValue("ws");
            SeleniumCustomMethods.MultiSelectElements(driver, By.Id("loanProvider"), ["jms","ws"]);



            //  Console.WriteLine(option.Text);

           var getSelectedOptions =SeleniumCustomMethods.GetAllSelectItem(driver,By.Id("loanProvider")) ;

            getSelectedOptions.ForEach(Console.WriteLine);




        }
    }
}




