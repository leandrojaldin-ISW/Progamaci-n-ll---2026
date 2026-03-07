namespace TiendaConsola;

//cantidad nombre , precio , 
//codigo , nombre , precio 

public class Producto
{
    private string codigo;
    private string nombre;
    private double precio;


    public Producto(string codigo, string nombre, double precio)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.precio = precio;
        
        
    }

    public string GetCodigo()
    {
        return this.codigo;
    }

    public string GetNombre()
    {
        return this.nombre;
    }

    public double GetPrecio()
    {
        return this.precio;
    }

    public void SetCodigo(string codigo)
    {
        if (codigo == "" || codigo == null)
        {
            //Console.WriteLine("Error: el codigo del producto no puede estar vacio);
            return;
        }
        else
        {
            this.codigo = codigo;
        }
    }

    public void SetNombre(string nombre)
    {
        if (nombre == "" || nombre == null)
        {
            //Console.WriteLine("Error: el nombre del producto no puede estar vacio");
            return;
        }
        else
        {
            this.nombre = nombre;
        }
    }

    public void SetPrecio(double precio)
    {
        if (precio <= 0)
        {
            //Console.WriteLine("El nombre no puede estar vacio")
            return;
        }
        else
        {
            this.precio = precio;
        }
    }
    
}