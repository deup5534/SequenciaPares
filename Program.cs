Console.Write("\nexibir números pares de 0 até...");
int numeroInicial = Convert.ToInt32(Console.ReadLine());

if (numeroInicial >=1)
{
    int numeroPar = 0;

    while (numeroPar <= numeroInicial)
    {
        Console.Write($"{numeroPar} ");
        numeroPar += 2;
    }
}
Console.WriteLine();