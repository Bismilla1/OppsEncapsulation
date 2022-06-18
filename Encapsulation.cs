public Class LoginPage
{   
     private IWebElement NameInput =return{get{ driver.FindElement(By.Id("txtUsername"))}};
     private IWebElement PasswordInput =return{Get{ driver.FindElement(By.Id("txtPassword"))}};
     private IWebElement LoginButton =return{Get{ driver.FindElement(By.Id("btnLogin"))}};
     
     public BasePage Login(string username, string password)
      {
             NameInput.SendKeys(username);
             PasswordInput.SendKeys(password);
             LoginButton.Click();
             return new BasePage(driver);
      }
          LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("admin", "admin123");// access for the method only , will not access webelements directly which are declared as private.

}
