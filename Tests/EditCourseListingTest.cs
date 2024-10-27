using OpenQA.Selenium;
using selenium_test_project.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_test_project.Tests
{
    internal class EditCourseListingTest
    {
        private IWebDriver driver;
        private CoursePage coursePage;

        public EditCourseListingTest(IWebDriver driver)
        {
            this.driver = driver;
            this.coursePage = new CoursePage(driver);
        }

        public void RunTest()
        {
            TestContext.Progress.WriteLine("Test started: EditCourseListingTest");
            try
            {

                coursePage.ClickEditCourseButton();


                // Clear and edit Coure Description
                Thread.Sleep(500);
                coursePage.ClearCourseDescription();
                Thread.Sleep(500);
                coursePage.EnterCourseDescription("EDITED");


                // Submit the form
                coursePage.SubmitForm();

                Thread.Sleep(500);

            }
            catch (Exception ex)
            {
                TestContext.Progress.WriteLine("Test failed: " + ex.Message);
                Assert.Fail("Test encountered an exception: " + ex.Message);
            }
            TestContext.Progress.WriteLine("Test Passed: EditCourseListingTest\n");

        }
    }
}