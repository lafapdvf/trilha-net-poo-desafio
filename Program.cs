using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Tijolo de Adamantium", imei: "1111111111", memoria: 64);
Console.WriteLine($"Criado Nokia número: {nokia.Numero}");
nokia.Ligar();
nokia.InstalarAplicativo("LinkedIn");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 25 Pro Max Daileon", imei: "2222222222", memoria: 128);
Console.WriteLine($"Criado iPhone número: {iphone.Numero}");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("GarageBand");