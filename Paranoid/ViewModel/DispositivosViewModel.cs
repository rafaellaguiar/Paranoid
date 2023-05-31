using Paranoid.Model;
using Paranoid.Service;

namespace Paranoid.ViewModel
{
    public class DispositivosViewModel
    {
        readonly BlueService blueService = new BlueService();
        public DispositivosViewModel()
        {
            this.dispositivos = blueService.GetDispositivosNaRede();
        }

        public List<Dispositivo> dispositivos { get; set; }
    }
}
