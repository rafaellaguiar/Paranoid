using Microsoft.AspNetCore.Mvc;
using Paranoid.Service;
using Paranoid.ViewModel;

namespace Paranoid
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            var dispositivos = new DispositivosViewModel();

            return View(dispositivos);
        }
    }
}
