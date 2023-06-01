using Paranoid.Helpers;

namespace Paranoid.Model
{
    public class Dispositivo
    {
        public string Ip { get; set; }
        private string _macAddress { get; set; }
        public string MacAdress {
            get { return _macAddress; }
            set { 
                _macAddress = value.Replace("-", ":").ToUpper(); 
            } 
        }
        private string _tipo { get; set; }
        public string Tipo { 
            get { return _tipo; } 
            set {
                _tipo = Helper.CapitalizeFirstLetter(value);
            } 
        } 
        public string Alias { get; set; }
    }
}
