using OpenQA.Selenium;

namespace POMDIP.Example.Navigation.Pages.CorreiosPages
{
    public class HomePage
    {
        protected static IWebDriver _driver;
        private By _searchTextBox = By.Id("acesso-busca");
        private By _searchButton = By.CssSelector("button.bt-link-ic i.ic-busca-out");
        public HomePage(IWebDriver driver) => _driver = driver;
        public HomePage SearchByCEP(string CEP)
        {
            _driver.Url = "http://www.correios.com.br";
            _driver.FindElement(_searchTextBox).SendKeys(CEP);
            _driver.FindElements(_searchButton)[^1].Click();

            return this;
        }
    }
}

