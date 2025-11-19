using OpenQA.Selenium;

namespace Presentation.Tests.Views.Products.Pages;

/// <summary>
///  Page Object Model for testing PRODUCT - CREATE PAGE
/// </summary>
/// <remarks>
/// Author: Luis López  
/// GitHub: https://github.com/luislopez-dev  
/// </remarks>
public class CreatePage
{
    private readonly IWebDriver _driver;
    
    private const string URI = "https://localhost:7209/products/Create";

    private IWebElement NameElement => _driver.FindElement(By.Id("InputName"));

    private IWebElement PriceElement => _driver.FindElement(By.Id("InputPrice"));

    private IWebElement StockElement => _driver.FindElement(By.Id("InputStock"));

    private IWebElement DescriptionElement => _driver.FindElement(By.Id("InputDescription"));

    private IWebElement ClickButton => _driver.FindElement(By.Id("Create"));

    public string Title => _driver.Title;

    public string Source => _driver.PageSource;

    public string NameErrorMessage => _driver.FindElement(By.Id("InputName-error")).Text;

    public string PriceErrorMessage => _driver.FindElement(By.Id("InputPrice-error")).Text;

    public string StockErrorMessage => _driver.FindElement(By.Id("InputStock-error")).Text;

    public string DescriptionErrorMessage => _driver.FindElement(By.Id("InputStock-error")).Text;
    
    public CreatePage(IWebDriver driver)
    {
        _driver = driver;
    }

    public void Navigate() => _driver.Navigate()
        .GoToUrl(URI);

    public void PopulateName(string name) => NameElement.SendKeys(name);

    public void PopulatePrice(string price) => PriceElement.SendKeys(price);

    public void PopulateStock(string stock) => StockElement.SendKeys(stock);

    public void PopulateDescription(string description) => DescriptionElement.SendKeys(description);

    public void ClickCreate() => ClickButton.Click();
}