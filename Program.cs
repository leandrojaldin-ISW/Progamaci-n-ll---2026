// See https://aka.ms/new-console-template for more information
using System;
namespace TiendaConsola;

public class progam
{
    public static void Main(string[] args)
    {
        PresentacionTienda miTienda = new PresentacionTienda();
        miTienda.Iniciar();
    }
}
