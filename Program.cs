using DesafioPOO.Models;
// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("");

Console.WriteLine("Nokia Smartphone:");
Nokia n1 = new Nokia("88020294", "Modelo 1011", "12345678", 64);
n1.Ligar();
n1.InstalarAplicativo("Whatsapp");
Console.WriteLine("Configuração");
n1.Configuracao();

Console.WriteLine("");

Console.WriteLine("Iphone Smartphone:");
Iphone sx = new Iphone("88011156", "Modelo SX", "98765432", 128);
sx.ReceberLigacao();
sx.InstalarAplicativo("Telegram");
Console.WriteLine("Configuração");
sx.Configuracao();

Console.WriteLine("");