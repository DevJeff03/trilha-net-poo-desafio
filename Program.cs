using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia1  = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "123456789", memoria: 64);
nokia1.Apresentar();
nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("PKXD");
Console.WriteLine();


Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "654321", modelo: "Modelo 2", imei: "456789123", memoria: 128);
iphone.Apresentar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");
Console.WriteLine();

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone2 = new Iphone(numero: "2468", modelo: "Iphone 15 Pro Max", imei: "741258963258741", memoria: 512);
iphone2.Apresentar();
iphone2.Ligar();
iphone2.ReceberLigacao();
iphone2.InstalarAplicativo("Instagram");