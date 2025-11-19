
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using Presentation.Tests.Views.Products.Pages;
using System;

namespace Presentation.Tests.Views.Products.Tests;

public class CreateTests {
    
}
/*
public class CreateTests : IDisposable
{
    private readonly IWebDriver _driver;
    private readonly CreatePage _createPage;

    public CreateTests()
    {
        var seleniumUrl = Environment
            .GetEnvironmentVariable("SELENIUM__URL") ?? "http://localhost:4444/wd/hub";
        var options = new ChromeOptions();
        _driver = new RemoteWebDriver(new Uri(seleniumUrl), options);
        _createPage = new CreatePage(_driver);
        _createPage.Navigate();
    }

  
    [Fact]
    public void Create_WhenExecuted_ReturnsCreateView()
    {
        Assert.Equal("Crear Producto", _createPage.Title);
    }

    // [Fact]
    // public void Create_WrongModelData_ReturnErrorMessage()
    // {
    //     
    // }

    [Fact]
    public void Create_WhenSuccessfullyExecuted_ReturnsIndexViewWithNewProduct()
    {
        _createPage.PopulateName("Rexona 50 ml");
        _createPage.PopulateDescription("Desodorante Rexona 50 ml");
        _createPage.PopulatePrice("25.00");
        _createPage.PopulateStock("100");
        _createPage.ClickCreate();
        Assert.Equal("Productos", _createPage.Title);
        Assert.Contains("Rexona 50 ml", _createPage.Source);
        Assert.Contains("25", _createPage.Source);
        Assert.Contains("100", _createPage.Source);
    }

    public void Dispose()
    {
        _driver.Quit();
        _driver.Dispose();
    }    
}
*/