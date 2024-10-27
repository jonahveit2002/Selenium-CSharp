using OpenQA.Selenium;

namespace selenium_test_project.PageModels
{
    public class CoursePage
    {
        private IWebDriver driver;

        // Constructor
        public CoursePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Page Elements

        // Add Course Fields
        private IWebElement EditCourseButton => driver.FindElement(By.XPath("//*[@id='app']/div/div/div[2]/div/div[1]/table/tbody/tr/td[8]/div/button[1]"));
        private IWebElement AddCourseButton => driver.FindElement(By.XPath("//*[@id='app']/div/div/div[2]/div/header/div/button"));
        private IWebElement DeleteCourseButton => driver.FindElement(By.XPath("//*[@id='app']/div/div/div[2]/div/div[1]/table/tbody/tr/td[8]/div/button[2]"));
        private IWebElement CourseDepartmentField => driver.FindElement(By.XPath("//form/div[2]/div[1]/div/div[3]/input"));
        private IWebElement CourseNumberField => driver.FindElement(By.XPath("//form/div[4]/div[1]/div/div[3]/input"));
        private IWebElement CourseLevelField => driver.FindElement(By.XPath("//form/div[6]/div[1]/div/div[3]/input"));
        private IWebElement CourseHoursField => driver.FindElement(By.XPath("//form/div[8]/div[1]/div/div[3]/input"));
        private IWebElement CourseNameField => driver.FindElement(By.XPath("//form/div[10]/div[1]/div/div[3]/input"));
        private IWebElement CourseDescriptionField => driver.FindElement(By.XPath("//form/div[12]/div[1]/div/div[3]/input"));
        private IWebElement SubmitButton => driver.FindElement(By.XPath("//*[@id='app']/div/div/form/button[2]/span[3]"));

        // Page Actions
        public void ClickAddCourseButton()
        {
            AddCourseButton.Click();
        }

        public void ClickEditCourseButton()
        {
            EditCourseButton.Click();
        }

        public void DeleteTopCourse()
        {
            DeleteCourseButton.Click();
        }

        // Entering Fields
        public void EnterCourseDepartment(string courseDepartment)
        {
            CourseDepartmentField.SendKeys(courseDepartment);
        }
        public void EnterCourseNumber(string courseNumber)
        {
            CourseNumberField.SendKeys(courseNumber);
        }
        public void EnterCourseLevel(string CourseLevel)
        {
            CourseLevelField.SendKeys(CourseLevel);
        }
        public void EnterCourseHours(string CourseHours)
        {
            CourseHoursField.SendKeys(CourseHours);
        }
        public void EnterCourseName(string courseName)
        {
            CourseNameField.SendKeys(courseName);
        }
        public void EnterCourseDescription(string courseDescription)
        {
            CourseDescriptionField.SendKeys(courseDescription);
        }
        public void ClearCourseDescription()
        {
            CourseDescriptionField.SendKeys(Keys.Control + "a");
            CourseDescriptionField.SendKeys(Keys.Delete);
        }


        public void SubmitForm()
        {
            SubmitButton.Click();
        }


    }
}
