using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Teste com Nokia");
Smartphone nokia = new Nokia("123456789", "Nokia 3310", "123456789IMEI", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

System.Console.WriteLine("----------------");


System.Console.WriteLine("Teste com iPhone");
Smartphone iphone = new Iphone("123456789", "Iphone 13", "987654321IMEI", 250);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");