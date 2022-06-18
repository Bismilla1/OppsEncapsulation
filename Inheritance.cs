public class BasePage
{
   protected readonly IWebDriver driver;
   private string title;
   private IWebElement LoggedUser => driver.FindElement(By.Id("welcome"));

   public BasePage(IWebDriver driver)
   {
      this.driver = driver;
   }
   
   public bool IsUserLoggedIn(string username)
   {
      return LoggedUser.Text.Contains(username);
   }
}

class AdminPage : BasePage
{
    public AdminPage(IWebDriver driver) : base(driver) { }
    
      AdminPage adminPage = new AdminPage(driver);
      Assert.IsTrue(adminPage.IsUserLoggedIn("paul"));
}


class BaseTest
{
   protected IWebDriver driver;
   [SetUp]
   public void Setup()
   {
      driver = new ChromeDriver();
     
   }
   
   [TearDown]
   public void Teardown()
   {
      driver.Quit();
   }
}

Class DashBordTests:BaseTest
{
 [Test]
   public void LoginTest()
   {
   
    driver.Url = "https://www.amazon.in/";
            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication();
   }
}

