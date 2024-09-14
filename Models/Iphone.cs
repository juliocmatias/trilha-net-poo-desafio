namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Apps = PegarAplicativos(dispositivo: "iphone_apps");
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Procurando app...");

            App app = Apps.Find(app => app.Nome.Equals(nomeApp, StringComparison.OrdinalIgnoreCase));
            if (app == null)
            {
                Console.WriteLine("Aplicativo não encontrado.");
                return;
            }
            if (Memoria >= app.Tamanho)
            {
                Console.WriteLine($"Memoria do dispositivo: {Memoria}MB");
                Console.WriteLine($"Tamanho do Aplicativo: {app.Tamanho}MB");
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