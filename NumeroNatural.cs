using System;
namespace DefaultNamespace;

public class NumeroNatural
{
    private int numero;
    
    //constructor
    public NumeroNatural()
    {
        numero = 0;
    }
    public NumeroNatural(int numero)
    {
        this.numero = numero;
    }

    public void PonerValor(int valor)
    {
        this.numero = valor;
    }

    public void mostrarValor()
    {
        Console.WriteLine("El valor es: " + numero);
    }


    public int getNumero()  //nos da un numero para ver o usarlo 
    {
        return numero;
    }

    public void setNumero(int nuevoValor)  //recive un numero de afuera para guardarlo adentro
    {
        numero = nuevoValor; //actualizamos atributo privado de nuestra clase
    }

    public bool NumPrimo(int valor)
    {
        if (this.numero <= 1) //descartamso 0 y uno
        {
            return false;
        }

        for (int divisor = 2; divisor < this.numero; divisor++)
        {
            if (this.numero % divisor == 0)
            {
                return false; //encontramos un divisor en el camnini
            }
        }
        return true; //termino todos los numeros 
    }
    
    //metodo para determinar la cantidad de digitos de un entero
    public int cantidadDigitos(int valor)
    {
        //para obtener la cantidad de digitos primero debmos sacar los numeros 
        int contador = 0;
        while (valor > 0)
        {
            valor = valor / 10;
            contador++;
        }

        return contador;
    }
    
    public void insertarNumEnPosiscion(int digitoNuevo, int posicion)
    {
        int multiplicador = 1;

        for (int i = 0; i < posicion; i++)
        {
            multiplicador = multiplicador * 10;
        }

        int parteIzquierda = this.numero / multiplicador;
        int parteDerecha = this.numero % multiplicador;

        int nuevaIzquierda = (parteIzquierda * 10) + digitoNuevo;
        
        this.numero = (nuevaIzquierda * multiplicador) + parteDerecha;
    }
    
    
}