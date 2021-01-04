using OpenQA.Selenium;

namespace POMDIP.Example.Navigation.Pages.DetranPages
{
    public class FormPage
    {
        protected static IWebDriver _driver;
        private By _logradouro = By.Id("proprietarioLogradouroTextBox");
        private By _bairro = By.Id("proprietarioBairroTextBox");
        private By _localidadeBox = By.Id("proprietarioVeiculoLabel");
        private By _localidadeField = By.Id("pesquisaTextBox");
        private By _localidadeButton = By.Id("selecionarButton");
        private By _cep = By.Id("proprietarioCepTextBox");
        public FormPage(IWebDriver driver) => _driver = driver;
        public FormPage SetCorreiosData(string[] correiosData)
        {
            _driver.Url = "http://formulario.detran.sp.gov.br/Planilha.aspx";
            _driver.FindElement(_logradouro).SendKeys(correiosData[0]);
            _driver.FindElement(_bairro).SendKeys(correiosData[1]);
            _driver.FindElement(_cep).SendKeys(correiosData[3]);
            return this;
        }
    }
}