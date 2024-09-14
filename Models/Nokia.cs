namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Apps = PegarAplicativos(dispositivo: "nokia_apps");
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            App app = Apps.Find(app => app.Nome.Equals(nomeApp, StringComparison.OrdinalIgnoreCase));
            if (app == null)
            {
                Console.WriteLine("Aplicativo não encontrado.");
                return;
            }
            if (Memoria >= app.Tamanho)
            {
                _memoria -= app.Tamanho;
                Console.WriteLine($"Aplicativo {app.Nome} instalado com sucesso! Memória restante: {Memoria}MB");
            }
            else
            {
                Console.WriteLine($"Memória insuficiente para instalar o aplicativo {app.Nome}. Requer {app.Tamanho}MB, mas apenas {Memoria}MB disponíveis.");
            }
        }
    }
}