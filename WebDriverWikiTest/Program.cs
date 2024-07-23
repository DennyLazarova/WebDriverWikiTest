using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace WebDriverWikiTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //create new Chrome browser

            WebDriver driver = new ChromeDriver();
           
           //Navigate to Wikipwdia page
            driver.Url = "https://www.wikipedia.org/";

            ////Find the Search field
            //var searchInput =  driver.FindElement(By.Id("searchInput"));

            ////Click on the Field
            //searchInput.Click();

            ////Type Quality Assurance
            //searchInput.SendKeys("Quality assurance" + Keys.Enter);

            driver.FindElement(By.Id("searchInput")).SendKeys("Quality assurance" + Keys.Enter);

            //Get the page title
            var currentPageTitle = driver.Title;

            //Print the page title
            Console.WriteLine("Current page title is: " + currentPageTitle);

            if (currentPageTitle == "Quality assurance - Wikipedia")
            {
                Console.WriteLine(" ***** Test PASS ***** ");
            }
            else
            {
                Console.WriteLine(" ***** Test FAIL ***** ");
            }



            //Close browser
            driver.Quit(); 
            
        }
    }
}