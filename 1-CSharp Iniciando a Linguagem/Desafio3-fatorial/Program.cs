using System;

class Programa
{
    static void Main(string[] args)
    {
        // minha resposta.
        for (int n = 1; n <= 10; n++)
        {
            for (int i = 1; i <= 10;  i++)
            {
                n *= i;
                Console.WriteLine("O fatorial de " + i + " é " + n);
            }
        }

        //^^ for desnecessário.

        //Implementação certa
        int fatorial = 1;
        for (int a = 1; a < 11; a++)
        {
            fatorial *= a;
            Console.WriteLine("Fatorial de " + a + " = " + fatorial);
        }
    }

}

