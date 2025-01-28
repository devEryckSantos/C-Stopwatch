
Start();

static void Start()
{
    int time = 10;
    int currentTime = 0;

    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000); // faz pausas de 1 segundo antes de voltar ao laço.
    }
}