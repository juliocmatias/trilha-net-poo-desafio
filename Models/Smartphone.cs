using Newtonsoft.Json;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de aco
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        protected int _memoria;
        public int Memoria
        { 
            get { return _memoria; }
        }

        protected List<App> Apps;
        
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMEI = imei;
            if (memoria < 1000) 
            {
                throw new ArgumentException("A memória deve ser maior ou igual 1G(1000MG).");
            }
            else 
            {
                _memoria = memoria;
            }
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        protected List<App> PegarAplicativos(string dispositivo)
        {
            string caminhoArquivo = "database/list_apps.json";
            
            string json = File.ReadAllText(caminhoArquivo);

            Dispositivos dispositivos = JsonConvert.DeserializeObject<Dispositivos>(json);

            if (dispositivo == "nokia_apps")
            {
                return dispositivos.NokiaApps;
            }
            else 
            {
                return dispositivos.IphoneApps;
            }
        }
    }
}