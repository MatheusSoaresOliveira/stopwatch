using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }
    static void Start(int time)
    {

        int currentTime = 0;

        while (time != currentTime)
        {
            Console.Clear();
            Console.WriteLine($"{time} segundos");
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000); //Espera 1000 milisegundos para aparecer o proximo numero
        }
    }
    static void Menu()
    {
        Console.Clear();
        string valor;
        int time;
        char type;
        int multiplier = 1;

        Console.WriteLine("Quanto tempo você quer no seu cronometro?\n10s = 10segundos\n10m = 10 minutos");
        valor = Console.ReadLine().ToLower();
        type = char.Parse(valor.Substring(valor.Length - 1, 1));
        time = int.Parse(valor.Substring(0, valor.Length - 1));

        Console.WriteLine(time);
        Console.WriteLine(type);

        if (type == 'm') //se o usuario optar por minuto, entao o multiplicador sera alterado para 60
            multiplier = 60;

        PreStart(time * multiplier); //Chama a função pre start multiplicando o tempo do usuario pelo multiplicador
    }

    static void PreStart(int time)
    {
        Console.Clear();
        Thread.Sleep(1000);
        Console.WriteLine("Readdy...");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Set...");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Go...");
        Thread.Sleep(1500);
        Console.Clear();

        Start(time);
    }
}
