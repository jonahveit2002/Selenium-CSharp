using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using selenium_test_project.TestCases;
using OpenQA.Selenium.DevTools.V127.CacheStorage;
using selenium_test_project.Tests;
using NuGet.Frameworks;

namespace selenium_test_project.TestSets
{
    [TestFixture]
    public class MassCourseAddTestSet : IDisposable
    {
        // hard coded variable
        private int num_of_Courses = 5;

        // IWebDriver variable
        private IWebDriver driver;

        // test classes
        private NavigateToCourseListingPage navigateToCourseListingPage;
        private AddCourseListingTest addCourseListingTest;
        private DeleteCourseListingTest deleteCourseListingTest;
        private EditCourseListingTest editCourseListingTest;
        

        [OneTimeSetUp]
        public void Setup()
        {

            TestContext.Progress.WriteLine("Setup method started");

            var options = new ChromeOptions();
            driver = new ChromeDriver(options);

            TestContext.Progress.WriteLine("Setup method completed");
        }

        #region Navigate To Landing Page
        [Test, Order(1)]
        public void NavigateToLandingPage()
        {
            navigateToCourseListingPage = new NavigateToCourseListingPage(driver);
            navigateToCourseListingPage.RunTest();

            Assert.Pass("Test passed: NavigateToLandingPage");

        }
        #endregion

        #region Add courses
        [Test, Order(2)]
        public void AddCourses()
        {
            addCourseListingTest = new AddCourseListingTest(driver);

            for (int i = 0; i < num_of_Courses; i++)
            {
                addCourseListingTest.RunTest();
                Thread.Sleep(500);
            }

            Assert.Pass("Test passed: AddCourseListingTest");
            
           
        }
        #endregion

        #region Edit course
        [Test, Order(3)]
        public void EditCourse()
        {
            editCourseListingTest = new EditCourseListingTest(driver);
            editCourseListingTest.RunTest();

            Assert.Pass("Test passed: EditCourseListingTest");

        }
        #endregion

        #region Delete course
        [Test, Order(4)]
        public void DeleteCourses()
        {
            Thread.Sleep(1000);

            deleteCourseListingTest = new DeleteCourseListingTest(driver);

            for (int i = 0; i < num_of_Courses; i++)
            {
                deleteCourseListingTest.RunTest();
                Thread.Sleep(500);
            }

            Assert.Pass("Test passed: DeleteCourseListingTest");

        }
        #endregion

        [OneTimeTearDown]
        public void TearDown()
        {
            Dispose();
        }

        public void Dispose()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }
    }
}
