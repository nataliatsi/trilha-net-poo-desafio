using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone smartNokia = new Nokia(numero: "123456789", modelo: "Nokia 9", imei: "012345678912345", memoria: 64);
smartNokia.Ligar();
smartNokia.ReceberLigacao();
smartNokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone smartIphone = new Iphone(numero: "987654321", modelo: "iPhone 12", imei: "987654321098765", memoria: 128);
smartIphone.Ligar();
smartIphone.ReceberLigacao();
smartIphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Samsung: ");
Smartphone samsung = new Samsung(numero: "987-6543", modelo: "Galaxy S20", imei: "999988887777666", memoria: 128);
samsung.Ligar();
samsung.ReceberLigacao();
samsung.InstalarAplicativo("Facebook");
