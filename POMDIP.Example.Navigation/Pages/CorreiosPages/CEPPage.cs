using System.Linq;
using OpenQA.Selenium;

namespace POMDIP.Example.Navigation.Pages.CorreiosPages
{
    public class CEPPage
    {
        protected static IWebDriver _driver;
        private By _tableResults = By.CssSelector("table#resultado-DNEC td");
        private By _logradouro = By.CssSelector("td[data-th='Bairro/Distrito']");
        private By _bairro = By.CssSelector("td[data-th='Logradouro/Nome']");
        private By _localidade = By.CssSelector("td[data-th='Localidade/UF']");
        private By _cep = By.CssSelector("td[data-th='CEP']");
        public CEPPage(IWebDriver driver) => _driver = driver;
        public bool HasResults()
        {
            _driver.SwitchTo().Window(_driver.WindowHandles[^1]);
            return _driver.FindElements(_tableResults).Any();
        }
        public string[] GetCEPData()
        {
            var logradouro = _driver.FindElement(_logradouro).Text;
            var bairro = _driver.FindElement(_bairro).Text;
            var localidade = _driver.FindElement(_localidade).Text;
            var cep = _driver.FindElement(_cep).Text;

            return new[]{logradouro,bairro,localidade,cep};
        }
    }
}
