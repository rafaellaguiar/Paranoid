using Microsoft.AspNetCore.Mvc;
using Paranoid.Model;
using Paranoid.Service;
using Paranoid.Service.Interfaces;

namespace Paranoid
{
    [Route("")]
    public class DispositivoController : Controller
    {
        IBlueService _blueService;
        ISpeculationService _speculationService;
        IRoundService _roundService;
        public DispositivoController(IBlueService blueService, ISpeculationService speculationService, IRoundService roundService)
        {
            _blueService = blueService;
            _speculationService = speculationService;
            _roundService = roundService;
        }

        [Route("/")]
        [HttpGet]
        public IActionResult Index()
        {
            List<Dispositivo> dispositivos = ObterDispositivos();

            ViewData["ListaDispositivos"] = dispositivos;

            return View();
        }

        [HttpGet]
        [Route("get/detalhe")]
        public async Task<DetalheDispositivo> DetalheDispositivo(string macAddress)
        {
            return await ObterDetalheDispositivo(macAddress);
        }

        private List<Dispositivo> ObterDispositivos()
        {
            return _blueService.GetDispositivosNaRede();
        }

        private async Task<DetalheDispositivo> ObterDetalheDispositivo(string macAddress)
        {
            return await _speculationService.GetDetalheDispositivo(macAddress);
        }
    }
}
