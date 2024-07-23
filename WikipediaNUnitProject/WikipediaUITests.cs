using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WikipediaNUnitProject
{
    public class WikipediaUITests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckPageTitle()
        {
         
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.wikipedia.org/");

                  
            
            Assert.That(driver.Title, Is.EqualTo("Wikipedia"));

            driver.Quit();
        }

        [Test]
        public void CheckQualityAssurancePageTitle()
        {
            
            //Arrange
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.wikipedia.org/");

            //Act
            driver.FindElement(By.Id("searchInput")).SendKeys("Quality assurance" + Keys.Enter);
            
            //Assert
            Assert.That(driver.Title, Is.EqualTo("Quality assurance - Wikipedia"));

            driver.Quit();
        }
    }
}