using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WikipediaNUnitProject
{
    public class WikipediaUITests
    {
        private ChromeDriver driver;
        
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.wikipedia.org/");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }


        [Test]
        public void CheckPageTitle()
        {                          
            Assert.That(driver.Title, Is.EqualTo("Wikipedia"));
        }


        [Test]
        public void CheckQualityAssurancePageTitle()
        {           
            //Act
            driver.FindElement(By.Id("searchInput")).SendKeys("Quality assurance" + Keys.Enter);
            
            //Assert
            Assert.That(driver.Title, Is.EqualTo("Quality assurance - Wikipedia"));

        }
    }
}