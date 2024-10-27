using NUnit.Framework;
using OpenQA.Selenium;
using selenium_test_project.PageModels;

namespace selenium_test_project.Tests
{
    public class DeleteCourseListingTest
    {
        private IWebDriver driver;
        private CoursePage coursePage;

        public DeleteCourseListingTest(IWebDriver driver)
        {
            this.driver = driver;
            this.coursePage = new CoursePage(driver);
        }

        public void RunTest()
        {
            TestContext.Progress.WriteLine("Test started: DeleteCourseListingTest");
            try
            {
                coursePage.DeleteTopCourse();

                Thread.Sleep(100);
            }
            catch (Exception ex)
            {
                TestContext.Progress.WriteLine("Test failed: " + ex.Message);
                Assert.Fail("Test encountered an exception: " + ex.Message);
            }

            TestContext.Progress.WriteLine("Test Passed: DeleteCourseListingTest\n");

        }
    }
}
