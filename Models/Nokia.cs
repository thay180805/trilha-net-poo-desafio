namespace DesafioPOO.Models
{
    // Nokia herda da classe Smartphone
    public class Nokia : Smartphone
    {
        // Construtor que chama o construtor da classe base
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            // Comportamento específico do Nokia
            Console.WriteLine($"Instalando o app {nomeApp} na loja do Nokia.");
        }
    }
}
