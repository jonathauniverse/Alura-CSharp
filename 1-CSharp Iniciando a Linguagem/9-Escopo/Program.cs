// Seusing System;
class Programa
{
    static void Main(string[] args)
    {
        // trecho de código omitido

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar!");
        }
        else
            Console.WriteLine("Não pode entrar!");
        Console.WriteLine("");

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}