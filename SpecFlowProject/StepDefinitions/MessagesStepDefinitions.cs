using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class MessagesStepDefinitions
    {
        IWebDriver driver;
        [Given(@"The user enters the Messages site")]
        public void GivenTheUserEntersTheMessagesSite()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://certicon-testing.azurewebsites.net/Home/Messages");
        }

        [Given(@"he enters the name ""([^""]*)""")]
        public void GivenHeEntersTheName(string name)
        {
            var nameInput = driver.FindElement(By.Id("Name"));
            nameInput.SendKeys(name);
        }

        [Given(@"he enters the email ""([^""]*)""")]
        public void GivenHeEntersTheEmail(string email)
        {
            var emailInput = driver.FindElement(By.Id("Email"));
            emailInput.SendKeys(email);
        }

        [Given(@"he enters the ""([^""]*)"" message")]
        public void GivenHeEntersTheMessage(string message)
        {
            var contentInput = driver.FindElement(By.Id("Content"));
            contentInput.SendKeys(message);
        }

        [When(@"he clicks the Create button")]
        public void WhenHeClicksTheCreateButton()
        {
            var buttonCreate = driver.FindElement(By.Id("buttonCreate"));
            buttonCreate.Click();
        }

        [Then(@"the success message should be displayed")]
        public void ThenTheSuccessMessageShouldBeDisplayed()
        {
            var successRibbon = driver.FindElement(By.Id("success"));
            Assert.AreEqual("The message has been saved", successRibbon.Text);
            var messageNumberLabel = driver.FindElement(By.Id("messageNumber"));
            Assert.AreEqual("You have 1 messages", messageNumberLabel.Text);
        }
        [Given(@"he forgots to enter the e-mail")]
        public void GivenHeForgotsToEnterTheE_Mail() {
            var emailInput = driver.FindElement(By.Id("Email"));
            emailInput.Click();
        }

        [Then(@"the e-mail error should be displayed")]
        public void ThenTheE_MailErrorShouldBeDisplayed() {
            var errorNameInput = driver.FindElement(By.ClassName("field-validation-error"));
            Assert.AreEqual("Email is Required", errorNameInput.Text);
        }

        [Then(@"He can close the browser")]
        public void ThenHeCanCloseTheBrowser() {
            driver.Close();
        }

    }
}
