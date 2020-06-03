using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace ZadatakaAziv
{
    class Testovi
    {
        IWebDriver driver;
        WebDriverWait wait;

        [Test]
        public void RegisterNewUser()
        {
            Navigate("http://shop.qa.rs");
            IWebElement linkRegister = wait.Until(EC.ElementIsVisible(By.LinkText("Register")));
            if (linkRegister.Displayed && linkRegister.Enabled)
            {
                linkRegister.Click();
            }
            IWebElement firstName = wait.Until(EC.ElementIsVisible(By.Name("ime")));
            if (firstName.Displayed && firstName.Enabled)
            {
                firstName.SendKeys("Zorz");
            }
            IWebElement lastName = wait.Until(EC.ElementIsVisible(By.Name("prezime")));
            if (lastName.Displayed && lastName.Enabled)
            {
                lastName.SendKeys("Vea");
            }
            IWebElement linkEmail = wait.Until(EC.ElementIsVisible(By.Name("email")));
            if (linkEmail.Displayed && linkEmail.Enabled)
            {
                linkEmail.SendKeys("silvio.berluskoni@galijani.com");
            }
            IWebElement username = wait.Until(EC.ElementIsVisible(By.Name("korisnicko")));
            if (username.Displayed && username.Enabled)
            {
                username.SendKeys("Rikardo");
            }
            IWebElement password = wait.Until(EC.ElementIsVisible(By.Name("lozinka")));
            if (password.Displayed && password.Enabled)
            {
                password.SendKeys("Kaka");
            }
            IWebElement confirmPassword = wait.Until(EC.ElementIsVisible(By.Name("lozinkaOpet")));
            if (confirmPassword.Displayed && confirmPassword.Enabled)
            {
                confirmPassword.SendKeys("Kaka");
            }
            IWebElement registerButton = wait.Until(EC.ElementIsVisible(By.Name("register")));
            if (registerButton.Displayed && registerButton.Enabled)
            {
                registerButton.Click();
            }

        }

        [Test]
        public void LoginWithCredentials()
        {
            Navigate("http://shop.qa.rs");
            IWebElement userLogin = wait.Until(EC.ElementIsVisible(By.LinkText("Login")));
            if (userLogin.Displayed && userLogin.Enabled)
            {
                userLogin.Click();
            }
            IWebElement loginUserName = wait.Until(EC.ElementIsVisible(By.Name("username")));
            if (loginUserName.Displayed && loginUserName.Enabled)
            {
                loginUserName.SendKeys("Rikado");
            }
            IWebElement loginPassword = wait.Until(EC.ElementIsVisible(By.Name("password")));
            if (loginPassword.Displayed && loginPassword.Enabled)
            {
                loginPassword.SendKeys("Kaka");
            }
            IWebElement loginInput = wait.Until(EC.ElementIsVisible(By.Name("login")));
            if (loginInput.Displayed && loginInput.Enabled)
            {
                loginInput.Click();
            }
           
        }
          


        private void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        [SetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();
            wait = new WebDriverWait(driver, new TimeSpan(0, 0, 40));
            driver.Manage().Window.Maximize();
        }


        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
