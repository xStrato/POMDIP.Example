using System.Threading.Tasks;
using POMDIP.Example.Navigation.Controllers;

namespace POMDIP.Example.Navigation
{
    public class Navigator
    {
        private Correios _correios { get; init; }
        private Detran _detran { get; init; }
        public Navigator(Correios correios, Detran detran)
            => (_correios, _detran) = (correios, detran);
        public Task<bool> Start(string[] ceps)
        {
            try
            {
                foreach (var cep in ceps)
                {
                    var data = _correios.Start(cep);
                    
                    if(data is not null)
                        _detran.Start(data);
                }
            }
            catch (System.Exception)
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }
    }
}