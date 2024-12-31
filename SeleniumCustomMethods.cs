using Microsoft.VisualBasic.FileIO;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenQA.Selenium.BiDi.Modules.Log.Entry;

namespace TestProject_for_selenium
{
    public class SeleniumCustomMethods
    {   //1.Method should get the locator
        //2.start getting the type of identifier
        //3.Perform operation on the locator
        public static void Submit(IWebDriver driver , By locator)
        {
             driver.FindElement(locator).Submit();
           
        }

        public static void EnterText(IWebDriver driver, By locator,string text)
        {    
            driver.FindElement(locator).Clear();
            driver.FindElement(locator).SendKeys(Keys.Enter);
        }
        public static void SelectDropDownByValue (IWebDriver driver, By locator,string value) {

            SelectElement selectElement = new SelectElement(driver.FindElement(locator));
            selectElement.SelectByValue(value);
        }

        public static void MultiSelectElements(IWebDriver driver, By locator, string[] values) { 
        
            SelectElement multiSelect = new SelectElement(driver.FindElement(locator));
            foreach (var value in values) {

              multiSelect.SelectByValue(value);
                
            }
          
        }

        public static List<string> GetAllSelectItem (IWebDriver driver, By locator) 
        {

            List<string> options = new List<string>();
            SelectElement multiSelect = new SelectElement(driver.FindElement(locator));

            IList<IWebElement> selectedOption = multiSelect.AllSelectedOptions;
            foreach (IWebElement option in selectedOption) 
            {
                options.Add(option.Text);
            
            }
            return options;


        }

    
    }
}
