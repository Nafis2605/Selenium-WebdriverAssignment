using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Integration_Testing
{
    class ITesting
    {
        IWebDriver driver;
        

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();                        //Open Browser
        }
        [Test]
        public void test()
        {
            driver.Url = "http://elp.duetbd.org";               //Destination URL

            IWebElement element1 = driver.FindElement(By.XPath("//*[@id='header']/div/ul/li[2]/div/span/a")); 
            element1.Click();                                   //Clicking Log In Page Link

            IWebElement element = driver.FindElement(By.Name("username"));
            element.SendKeys("170042004");                      //Entering the student ID
            IWebElement password = driver.FindElement(By.Name("password"));
            password.SendKeys("@26051998Nafis");                //Entering the passeord
            driver.FindElement(By.Id("loginbtn")).Click();      //Clicking the Log in Button
            String at = driver.Title;
            String et = "Dashboard";                            //Checking dashboard page has arrived or not
            if (at == et)
            {
                Console.WriteLine("Test Successful");           //Successful testing Indicator 
            }
            else
            {
                Console.WriteLine("Unsuccessful");              //Unsuccessful testing Indicator
            }
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();                                     //Browser will be closed
        }
    }
}
