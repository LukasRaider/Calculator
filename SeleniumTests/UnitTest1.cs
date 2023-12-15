using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests {
  [TestClass]
    public class UnitTest1 {
        //https://certicon-testing.azurewebsites.net/
        IWebDriver driver;
        IWebElement messagesLink;

        [TestInitialize]
        public void Init() {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://certicon-testing.azurewebsites.net/");
            messagesLink = driver.FindElement(By.LinkText("Messages"));
            messagesLink.Click();
        }
        [TestMethod]
        public void EverythingOk() {
            EnterTheName("Franta");
            EnterTheEmail("franta@frantavoprsalek.cz");
            EnterTheMessage("Ahoj vsem");
            ClickTheCreateButton();
            var successRibbon = driver.FindElement(By.Id("success"));
            Assert.AreEqual("The message has been saved", successRibbon.Text);
            var messageNumberLabel = driver.FindElement(By.Id("messageNumber"));
            Assert.AreEqual("You have 1 messages", messageNumberLabel.Text);
        }

        private void ClickTheCreateButton() {
            var buttonCreate = driver.FindElement(By.Id("buttonCreate"));
            buttonCreate.Click();
        }

        private void EnterTheMessage(string message) {
            var contentInput = driver.FindElement(By.Id("Content"));
            contentInput.SendKeys(message);
        }

        private void EnterTheEmail(string mail) {
            var emailInput = driver.FindElement(By.Id("Email"));
            emailInput.SendKeys(mail);
        }

        private void EnterTheName(string name) {
            var nameInput = driver.FindElement(By.Id("Name"));
            nameInput.SendKeys(name);
        }

        [TestMethod]
        public void ForgotToEnterEmail() {
            EnterTheName("Karel");
            EnterTheMessage("Ahoj bando");
            ClickTheCreateButton();
            var errorNameInput = driver.FindElement(By.ClassName("field-validation-error"));
            Assert.AreEqual("Email is Required", errorNameInput.Text);
        }
        [TestCleanup]
        public void Cleanup() {
            driver.Close();
        }
    }
}