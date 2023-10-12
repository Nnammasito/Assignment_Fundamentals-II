//1. Imprimir 1-255.

static void printNumbers()
{   
    //Print all of the integers from 1 to 255.
    for(int i = 1; i <= 255; i++)
    {
        Console.WriteLine(i);
    }
}
printNumbers();

//2. Imprimir números impares entre 1-255.

static void printOdds()
{
    //Print all of the odd integers from 1 to 255.
    for(int i = 1; i <=255; i++)
    {
        if(i%2 == 1)
        {
            Console.WriteLine(i);
        }
    }
}
printOdds();

//3. Imprimir Suma.

static void printSum()
{
    // Imprime todos los números del 0 al 255,
    // pero esta vez, también imprime la suma sobre la marcha.
    int resultaTemporal = 1;
    for(int i = 0; i <=255; i++)
    {
        Console.WriteLine("Nuevo numero: "+ i + " Suma: " + resultaTemporal);
        resultaTemporal += i;
    }
}
printSum();