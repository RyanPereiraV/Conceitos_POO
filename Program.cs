using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia n1 = new Nokia("11 9999-9999","Nokia1024","948474",8);
n1.InstalarAplicativo("Telegram");
n1.ReceberLigacao();

Console.WriteLine("\n");

Iphone i1 = new Iphone("11 8888-8888","Iphone1","69848",32);
i1.InstalarAplicativo("Facebook");
i1.ReceberLigacao();
