using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    public class Demo3SignUP
    {
        public static void Main2(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/"; //wait for page load to complete

            //click on create new account
            //FindElement - takes only 0.5s to check presence of element
            driver.FindElement(By.LinkText("Create new account")).Click();

            //Thread.Sleep(7000); // not recomended
            //enter first name as john
            driver.FindElement(By.Name("firstname")).SendKeys("John");

            //enter last name as wick
            driver.FindElement(By.Name("lastname")).SendKeys("Wick");

            //enter password as welcome124
            driver.FindElement(By.Id("password_step_input")).SendKeys("welcome123");

            //20 Dec 2000
            //select date as 20
            SelectElement selectDay = new SelectElement(driver.FindElement(By.Id("day")));
            selectDay.SelectByText("20");

            //select month as Dec
            SelectElement selectMonth = new SelectElement(driver.FindElement(By.Id("month")));
            selectMonth.SelectByText("Dec");
            //selectMonth.SelectByValue("12");
            //selectMonth.SelectByIndex(11);

            //select year as 2000
            SelectElement selectYear = new SelectElement(driver.FindElement(By.Id("year")));
            selectYear.SelectByText("2000");

            //click on custom radio button

            //relative xpath and absoulte xpath
            //absolute xpath not recomended so we shld go for relative xpath

            //tagname[@attribute='']
            //tagname[text()='']


            //example
            //tagname is input
            //input[@value='-1']
            //label[text()='Custom']

            driver.FindElement(By.XPath("//input[@value='-1']")).Click();

            //click on signup
            //another mthos to click on sign up is 
                //button
            driver.FindElement(By.Name("websubmit")).Click();

            //driver.FindElement(By.XPath("//span[contains(@id,'UserPhone")).Text;

            //

        }
    }
}
