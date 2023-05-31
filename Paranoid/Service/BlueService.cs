using Paranoid.Helpers;
using Paranoid.Model;
using Paranoid.Service.Interfaces;
using System.Diagnostics;

namespace Paranoid.Service
{
    public class BlueService : IBlueService
    {
        List<Dispositivo> listaDispositivos = new List<Dispositivo>();
        public List<Dispositivo> GetDispositivosNaRede()
        {
            Process p = new Process();
            
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/C arp -a";

            p.Start();
            string output = p.StandardOutput.ReadToEnd();

            if (output.Equals("") || output.Equals(string.Empty))
                return listaDispositivos;

            string[] lines = output.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            foreach (string line in lines)
            {
                string[] items = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (items.Length >= 3)
                {
                    if (items[2].Equals("---"))
                        continue;

                    if (items[0].Equals("Endereço"))
                        continue;

                    Dispositivo dispostivo = new Dispositivo();

                    dispostivo.Ip = items[0];
                    dispostivo.MacAdress = items[1];
                    dispostivo.Tipo = Helper.CapitalizeFirstLetter(items[2]);

                    listaDispositivos.Add(dispostivo);
                }
            }

            return listaDispositivos.DistinctBy(m => m.MacAdress).ToList();
        }
    }

    
}
