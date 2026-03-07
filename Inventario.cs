namespace TiendaConsola;

public class Inventario
{
    private Producto[] vectorProductos;
    private int longitud;
     //private List<Producto> listaProductos;

     //public Inventario()
     //{
          //nace vacia pero la lista crece infinitamente 
         // this.listaProductos = new List<Producto>();
     //}
     
     public Inventario()
     {
         this.vectorProductos = new Producto[100];
         this.longitud = 0;
     }
     
     
     public void AgregarProducto(Producto nuevoProducto)
     {
         if (nuevoProducto != null)
         {
             if (this.longitud < this.vectorProductos.Length)
             {
                 this.vectorProductos[this.longitud] = nuevoProducto;
                 
                 this.longitud++;
             }
             else
             {
                 Console.WriteLine("Error: El inventario está lleno.");
             }
         }
     }
     
     public void MostrarInventario()
     {
         Console.WriteLine(" LISTA DE PRODUCTOS ");
         
         if (this.longitud == 0)
         {
             Console.WriteLine("El inventario está vacío en este momento.");
             return;
         }
         
         for (int i = 0; i < this.longitud; i++)
         {
             Producto p = this.vectorProductos[i];
             Console.WriteLine(p.GetCodigo() + " , " + p.GetNombre() + " , " + p.GetPrecio() + " Bs.");
         }
     }
     
     public int GetLongitud()
     {
         return this.longitud;
     }

     public Producto[] GetVectorProductos()
     {
         return this.vectorProductos;
     }
}


