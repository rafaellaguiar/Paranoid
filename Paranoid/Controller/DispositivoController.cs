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
        public DispositivoController(IBlueService blueService)
        {
            _blueService = blueService;
        }

        [Route("/")]
        [HttpGet]
        public IActionResult Index()
        {
            List<Dispositivo> dispositivos = ObterDispositivos();

            ViewData["ListaDispositivos"] = dispositivos;

            return View();
        }

        private List<Dispositivo> ObterDispositivos()
        {
            return _blueService.GetDispositivosNaRede();
        }
    }
}
