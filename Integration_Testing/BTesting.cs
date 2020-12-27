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
    class BTesting
    {
        IWebDriver driver;


        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();                        // Open the Browser
        }
        [Test]
        public void test()
        {
            driver.Navigate().GoToUrl("http://www.google.com/");
            IWebElement element1 = driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[1]/div/div[2]/input")); 
            element1.SendKeys("IUT");                           //Searching the search bar with xpath and searching IUT

            IWebElement element2 = driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[3]/center/input[1]"));
            element2.Click();                                   //Clicking the link of IUT
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();                                     //Close the borwser
        }
      
    }
}
