using Paranoid.Model;

namespace Paranoid.Service
{
    public interface ISpeculationService
    {
        Task<DetalheDispositivo> GetDetalheDispositivo(string macAddress);
    }
}
