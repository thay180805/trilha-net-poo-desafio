namespace DesafioPOO.Models
{
    // Iphone herda de Smartphone
    public class Iphone : Smartphone
    {
        // Construtor que chama o construtor da classe base
        public Iphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            // Comportamento específico do Iphone
            Console.WriteLine($"Instalando o app {nomeApp} na App Store do iPhone.");
        }
    }
}
