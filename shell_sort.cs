using System;

class Program
{
    static void HacerIntercambio(ref int a, ref int b)
    {
        int temporal = a;
        a = b;
        b = temporal;
    }

    static void OrdenamientoShell(int[] arreglo)
    {
        int tamano = arreglo.Length;

        for (int salto = tamano / 2; salto > 0; salto /= 2)
        {
            for (int explorador = salto; explorador < tamano; explorador++)
            {
                for (int retador = explorador; retador >= salto && arreglo[retador - salto] > arreglo[retador]; retador -= salto)
                {
                    HacerIntercambio(ref arreglo[retador], ref arreglo[retador - salto]);
                }
            }
        }
    }

    static void Main()
    {
        int[] numeros = { 15, 3, 9, 8, 5, 2, 7, 1, 6 };
        OrdenamientoShell(numeros);
        
        foreach (int n in numeros) 
        {
            Console.Write(n + " ");
        }
    }
}