using NUnit.Framework;
using OpenQA.Selenium;

namespace selenium_test_project.TestCases
{
    public class NavigateToCourseListingPage
    {
        private IWebDriver driver;

        public NavigateToCourseListingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void RunTest()
        {
            TestContext.Progress.WriteLine("Test started: NavigateToCourseListingPage");
            try
            {
                TestContext.Progress.WriteLine("Attempting to navigate to page");
                // driver.Navigate().GoToUrl("http://localhost:8080/2024/project2/t1/");
                driver.Navigate().GoToUrl("http://project2.eaglesoftwareteam.com/2024/project2/t1/");
                TestContext.Progress.WriteLine("Navigated to course listing");

                Thread.Sleep(100);
            }
            catch (Exception ex)
            {
                TestContext.Progress.WriteLine("Test failed: " + ex.Message);
            }
        }
    }
}
