using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Criando um Iphone
        Iphone iphone = new Iphone(
            numero: "1234-5678",
            modelo: "iPhone 14",
            imei: "111222333444555",
            memoria: 128
        );

        // Criando um Nokia
        Nokia nokia = new Nokia(
            numero: "9876-5432",
            modelo: "Nokia 3310",
            imei: "555444333222111",
            memoria: 32
        );

        // Testando métodos do Iphone
        Console.WriteLine("=== Teste Iphone ===");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Testando métodos do Nokia
        Console.WriteLine("=== Teste Nokia ===");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Telegram");

        Console.WriteLine();

        // Exibindo informações dos celulares
        Console.WriteLine($"Iphone: Modelo: {iphone.Modelo}, IMEI: {iphone.Imei}, Memória: {iphone.Memoria}GB");
        Console.WriteLine($"Nokia: Modelo: {nokia.Modelo}, IMEI: {nokia.Imei}, Memória: {nokia.Memoria}GB");
    }
}
