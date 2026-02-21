using System;

class Program
{
    static void HacerIntercambio(ref int a, ref int b)
    {
        int temporal = a;
        a = b;
        b = temporal;
    }

    static int Particion(int[] arreglo, int inicio, int fin)
    {
        int pivote = arreglo[fin];
        int muro = inicio - 1;

        for (int explorador = inicio; explorador < fin; explorador++)
        {
            if (arreglo[explorador] < pivote)
            {
                muro++;
                HacerIntercambio(ref arreglo[muro], ref arreglo[explorador]);
            }
        }
        HacerIntercambio(ref arreglo[muro + 1], ref arreglo[fin]);
        return muro + 1;
    }

    static void OrdenamientoRapido(int[] arreglo, int inicio, int fin)
    {
        if (inicio < fin)
        {
            int asientoPivote = Particion(arreglo, inicio, fin);
            OrdenamientoRapido(arreglo, inicio, asientoPivote - 1);
            OrdenamientoRapido(arreglo, asientoPivote + 1, fin);
        }
    }

    static void Main()
    {
        int[] numeros = { 15, 3, 9, 8, 5, 2, 7, 1, 6 };
        OrdenamientoRapido(numeros, 0, numeros.Length - 1);
        
        foreach (int n in numeros) 
        {
            Console.Write(n + " ");
        }
    }
}