using System.Diagnostics;

Console.WriteLine("1. Diez hilos compiten");
Console.WriteLine("2. Experimento de prioridades");
Console.WriteLine("3. Prioridades con un solo núcleo");
Console.Write("Elige: ");
string? opcion = Console.ReadLine();

if (opcion == "1") DiezHilos();
else if (opcion == "2") Prioridades(false);
else if (opcion == "3") Prioridades(true);


static void DiezHilos()
{
    int[] sumas = new int[10];
    Thread[] hilos = new Thread[10];

    for (int i = 0; i < hilos.Length; i++)
    {
        int k = i;
        hilos[k] = new Thread(() =>
        {
            int suma = 0;
            for (int j = 0; j < 100; j++)
            {
                int numero = Random.Shared.Next(1, 1001);
                suma += numero;
            }

            sumas[k] = suma;
        })
        {
            Name = $"Hilo {k}"
        };
        
        hilos[k].Start();
    }

    foreach (Thread hilo in hilos)
    {
        hilo.Join();
    }


    int maxima = sumas.Max();
}

static void Prioridades(bool unNucleo)
{
    // Parte B
}