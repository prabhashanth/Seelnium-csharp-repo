﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unisys.SeleniumConcepts
{
    public class program
    {
        public static void Main1(string[] args)
        {

            //ChromeDriver obj = new ChromeDriver();

            IWebDriver obj= new ChromeDriver();
            IWebDriver obj1= new ChromeDriver();
            IWebDriver obj2 = new ChromeDriver();

            //obj = new EdgeDriver();

            obj.Url = "https://www.facebook.com/";
            obj2.Url = "https://www.Google.co.in/";

            obj.Quit();
            obj2.Quit();

            //string actualTitle = obj.Title;
            //Console.WriteLine(actualTitle);

            //string pageSource = obj.PageSource;
            //Console.WriteLine(pageSource);

            //obj.Quit();

        }
    }
}