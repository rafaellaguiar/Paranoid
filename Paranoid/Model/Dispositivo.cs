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
        public string Tipo { get; set; } 
        public string Alias { get; set; }
    }
}
