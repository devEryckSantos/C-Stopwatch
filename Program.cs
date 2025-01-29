
Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("1 - Contagem progressiva");
    Console.WriteLine("2 - Contagem regressiva");
    Console.WriteLine("3 - Fechar programa.");
    int op = int.Parse(Console.ReadLine());

    if (op == 3)
    {
        Console.WriteLine("Fechando programa...");
        Environment.Exit(0);
    } else if (op > 3 || op <1)
    {
        Menu();
    } else
    {
        Console.Clear();
        Console.WriteLine("Até quanto deseja contar?");
        int value = int.Parse(Console.ReadLine());

        PreStart(value, op);
    }



}

static void PreStart(int value, int op)
{
    Console.Clear();
    Console.WriteLine("Ready?");
    Thread.Sleep(1000);
    Console.Clear();
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.Clear();
    Console.WriteLine("GO!");
    Thread.Sleep(1000);

    Start(value, op);
}

static void Start(int time, int op)
{
    int currentTime = 0;

    if (op == 1)
    {
        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000); // faz pausas de 1 segundo antes de voltar ao laço.
        }
    } else
    {
        currentTime = time;
        while (currentTime != 0)
        {
            Console.Clear();
            Console.WriteLine(currentTime);
            currentTime--;
            Thread.Sleep(1000); // faz pausas de 1 segundo antes de voltar ao laço.
        }
    }


    Console.Clear();
    Console.WriteLine("Contagem finalizada!");
    Thread.Sleep(2000);
    Menu();
}

