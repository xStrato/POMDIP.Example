using POMDIP.Example.Navigation.Pages.DetranPages;

namespace POMDIP.Example.Navigation.Controllers
{
    public class Detran
    {
        private FormPage _formPage { get; init; }
        public Detran(FormPage formPage) => _formPage = formPage;
        public void Start(string[] correiosData)
        {
            _formPage.SetCorreiosData(correiosData);
        }
    }
}