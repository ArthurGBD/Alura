
static void Main(string[] args)
{

    //static long FatorialEmParalelo(int valor)
    //{
    //    long resultado = 0;

    //    var t_calculo = new Thread(() => resultado = Fatorial(valor));
    //    t_calculo.Start();

    //    return resultado;
    //}

    // static long Fatorial(int valor)
    //{
    //    var resultado = 1L;
    //    for (int i = valor; i >= 2; i--)
    //        resultado *= i;
    //    Console.WriteLine(resultado);
    //    return resultado;
    //    Console.WriteLine(" ");
    //    Console.WriteLine(resultado);
    //}

    for (int i = 0; i < 10; i++)
    {

        var thread = new Thread(() => Thread.Sleep(5000));
        var isAlive = thread.IsAlive;
        Console.WriteLine(isAlive);
    }

}


