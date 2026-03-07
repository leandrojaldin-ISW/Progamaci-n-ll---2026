namespace TiendaConsola;

public class PresentacionTienda
{
    private Inventario inventarioTienda;
        private Carrito carritoCliente;

        public PresentacionTienda()
        {
            this.inventarioTienda = new Inventario();
            this.carritoCliente = new Carrito();
            CargarProductosPrueba();
        }

    
        private void CargarProductosPrueba()
        {
            inventarioTienda.AgregarProducto(new Producto("P001", "Laptop Asus Vivobook 16X", 8500.00));
            inventarioTienda.AgregarProducto(new Producto("P002", "Mouse Logitech G203", 150.00));
            inventarioTienda.AgregarProducto(new Producto("P003", "Teclado Mecánico Redragon", 320.00));
            inventarioTienda.AgregarProducto(new Producto("P004", "Monitor Samsung 24 pulgadas", 1200.00));
            inventarioTienda.AgregarProducto(new Producto("P005", "Audífonos HyperX Cloud", 650.00));
            inventarioTienda.AgregarProducto(new Producto("P006", "Memoria RAM Corsair 16GB", 450.00));
            inventarioTienda.AgregarProducto(new Producto("P007", "Disco Sólido SSD 1TB NVMe", 700.00));
            inventarioTienda.AgregarProducto(new Producto("P008", "Tarjeta Gráfica RTX 4050", 2800.00));
            inventarioTienda.AgregarProducto(new Producto("P009", "Silla Gamer DXRacer", 1500.00));
            inventarioTienda.AgregarProducto(new Producto("P010", "Mousepad XXL", 90.00));
        }
        
        public void Iniciar()
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\nTienda online");
                Console.WriteLine("opciones");
                Console.WriteLine("1. Mostrar inventario");
                Console.WriteLine("2. salir");
                Console.Write("Elige una opción: ");
                
                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    this.inventarioTienda.MostrarInventario();
                }
                else if (opcion == "2")
                {
                    salir = true;
                    Console.WriteLine("Saliendo de la tienda...");
                }
                else
                {
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                }
            }
        }
    }
