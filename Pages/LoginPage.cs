using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V129.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_for_selenium.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;
        private object input;

        public LoginPage(IWebDriver driver) 
        {

            this.driver = driver;
        
        }

        //IWebElement LoginLink => driver.FindElement(By.Id("loginlink"));
        IWebElement TxtUser => driver.FindElement(By.Name("username"));
        IWebElement TxtPassword => driver.FindElement(By.Name("password"));
        IWebElement BtnLogin => driver.FindElement(By.CssSelector("input.button"));

        //public void ClickLogin()
        //{
           // LoginLink.Click();
           //SeleniumCustMethods.Click(LoginLink);

       // }
        public void Login(String username, string password)
        {
            TxtUser.SendKeys(username);
            TxtPassword.SendKeys(password);
            BtnLogin.Submit();
         
        }

    }
}
