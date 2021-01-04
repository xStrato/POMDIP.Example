using POMDIP.Example.Navigation.Pages.CorreiosPages;

namespace POMDIP.Example.Navigation.Controllers
{
    public class Correios
    {
        private HomePage _homePage { get; init; }
        private CEPPage _cepPage { get; init; }
        public Correios(HomePage homePage, CEPPage cepPage)
        {
            _homePage = homePage;
            _cepPage = cepPage;
        }
        public string[] Start(string cep)
        {
            _homePage.SearchByCEP(cep);

            if(_cepPage.HasResults())
                return _cepPage.GetCEPData();

            return default;
        }
    }
}

