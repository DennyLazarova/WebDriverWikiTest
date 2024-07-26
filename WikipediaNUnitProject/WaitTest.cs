using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikipediaNUnitProject
{
    public class WaitTest
    {
        private ChromeDriver driver;
        
        [SetUp]
        public void Setup()
        {
           driver = new ChromeDriver();
           driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [TearDown]
        public void TearDown()
        {
           driver.Quit();
           driver.Dispose();
        }
        [Test]
        public void WaitExample()
        {
            
            driver.Url = "http://www.uitestingplayground.com/ajax";

           //click on the element
            driver.FindElement(By.Id("ajaxButton")).Click();
           

            string fieldText = driver.FindElement(By.ClassName("bg-success")).Text;

            Assert.That(fieldText, Is.EqualTo("Data loaded with AJAX get request."));

           
        }

    }

}
