using CelularProject.Models;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia(numero: "123456", modelo: "modelo 1", imei: "1111111", memoria: 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("Whatsapp");

        Console.WriteLine();

        Console.WriteLine("Smartphone Iphone:");
        Smartphone iphone = new Iphone(numero: "1234535436", modelo: "modelo 2", imei: "4441111", memoria: 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Telegram");
    }
}