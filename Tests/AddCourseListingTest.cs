using NUnit.Framework;
using OpenQA.Selenium;
using selenium_test_project.PageModels;

namespace selenium_test_project.Tests
{
    public class AddCourseListingTest
    {
        private IWebDriver driver;
        private CoursePage coursePage;

        public AddCourseListingTest(IWebDriver driver)
        {
            this.driver = driver;
            this.coursePage = new CoursePage(driver);
        }

        public void RunTest()
        {
            TestContext.Progress.WriteLine("Test started: AddCourseListingTest");
            try
            { 

                coursePage.ClickAddCourseButton();

                coursePage.EnterCourseDepartment("Samp");
                coursePage.EnterCourseNumber("1234");
                coursePage.EnterCourseLevel("1");
                coursePage.EnterCourseHours("3");
                coursePage.EnterCourseName("Sample Course Name");
                coursePage.EnterCourseDescription("Sample Course Description");


                coursePage.SubmitForm();

                Thread.Sleep(100);

            }
            catch (Exception ex)
            {
                TestContext.Progress.WriteLine("Test failed: " + ex.Message);
                Assert.Fail("Test encountered an exception: " + ex.Message);
            }
            TestContext.Progress.WriteLine("Test passed: AddCourseListingTest\n");


        }
    }
}
