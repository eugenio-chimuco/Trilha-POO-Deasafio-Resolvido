using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia= new Nokia (numero:"1234543",modelo:"modelo N250",imei:"09865145",memoria:19);
nokia.Ligar();
nokia.InstalarAplicativo("Watsapp");
Console.WriteLine("\n");
Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "976541", modelo: "modelo I03", imei: "0001110002", memoria: 32);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
