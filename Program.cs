// See https://aka.ms/new-console-template for more information
using System;
namespace DefaultNamespace;

public class Progam
{
    public static void Main(String[] args)
    {
        //creamos el objeto con el constructor vacio
        NumeroNatural n1 = new NumeroNatural();
        //introducimos un valor
        n1.PonerValor(1);
        n1.mostrarValor();
        //creamos otro objeto con el constructor con paramtro
        NumeroNatural n2 = new NumeroNatural(1234);
        n2.mostrarValor();
        
        Console.WriteLine("Cantida de digitos para " + n2.getNumero() + " es: " + n2.cantidadDigitos(n2.getNumero()));
    }
}