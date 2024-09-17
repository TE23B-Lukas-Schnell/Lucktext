// See https://aka.ms/new-console-template for more information
/*string fortnite = "hop off the battlebus";
string ballsack = "bollsäck";
Console.WriteLine($"hej {fortnite + ballsack}, jag med!");
Console.ReadLine();*/
using System.Runtime.CompilerServices;

int rättsvar = 0;
int poäng = 0;
bool restart = true;
Console.WriteLine("vad heter du?");
string name = Console.ReadLine();
Console.WriteLine($"hej {name}!");
Console.ReadLine();

void frågaFrameWork(string fråga, string svar, int svårighetsgrad){
    Console.WriteLine($"{fråga}, svårighetsgrad: {svårighetsgrad}");
    string input = Console.ReadLine().ToLower();

    if(input == svar){
        rättsvar ++;
        poäng += svårighetsgrad;
        Console.WriteLine($"du hade rätt, du får {svårighetsgrad} poäng");
        Console.ReadLine();
    }
    else{
        Console.WriteLine("din iq är lägre än rumstemperaturen");
        Console.WriteLine($"svaret var {svar}");
        Console.ReadLine();
    }
}

while(restart){
    Console.WriteLine("Du ska få svara på några frågor");
    Console.ReadLine();

    frågaFrameWork("Vad är tysklands huvudstad?","berlin",1);
    frågaFrameWork("Vad är Obamas efternam?","obama",5);
    frågaFrameWork("Vad är 3+5?","8",1);
    frågaFrameWork("Vad heter världens högsta torn?","burj khalifa", 2);
    frågaFrameWork("hur många ben har man i kroppen","206",3);

    Console.WriteLine($"nu är frågorna slut, du fick {poäng} poäng och {rättsvar} rättsvar");
    Console.ReadLine();
    restart = false;
    Console.WriteLine("skriv a för att köra igen");
    string input = Console.ReadLine().ToLower();
    if(input == "a"){
        restart = true;
    }
}