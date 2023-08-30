using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumConcepts
{
    public class Demo4SalesForce
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.salesforce.com/"; //wait for page load to complete

            driver.FindElement(By.Name("UserFirstName")).SendKeys("Wick");
            driver.FindElement(By.XPath("//input[contains(@id=,'UserLas')]")).Click();
            driver.FindElement(By.Name("UserEmail")).SendKeys("john@gmail.com");

            SelectElement selectJobTitle = new SelectElement(driver.FindElement(By.Name("UserTitle")));
            selectJobTitle.SelectByValue("IT_Manager_AP");

            driver.FindElement(By.Name("CompanyName")).SendKeys("Unisys");
            SelectElement selectEMp = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));






        }
    }
}
