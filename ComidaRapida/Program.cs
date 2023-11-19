using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ComidaRapida
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Usuario> usuarios = new List<Usuario>();
            List<Producto> productos = new List<Producto>();
            List<Pedido> pedidos = new List<Pedido>();

            CargarUsuarios(usuarios);
            /*foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine(usuario);
            }*/

            CargarProductos(productos);
            /*foreach (Producto producto in productos)
            {
                Console.WriteLine(producto);
            }*/

            CargarPedidos(pedidos, usuarios, productos);
            foreach (Pedido pedido in pedidos)
            {
                Console.WriteLine(pedido);
            }
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());*/
        }

        static void CargarUsuarios (List<Usuario> lista)
        {
            //variables de configuración
            string ubicacion = $"C:\\ComidaRapida\\usuarios.txt";
            string texto = "";
            string[] linea;
            string separador = "\t";

            //inicialización de variables
            int id;
            string usuario, clave;
            Usuario nuevoUsuario;

            //comienzo de lectura línea por línea
            StreamReader sr = new StreamReader(ubicacion);
            while(true)
            {
                texto = sr.ReadLine();

                //sale cuando no quedan líneas por leer
                if (texto == null || texto == "")
                {
                    break;
                }

                //divide la línea en tabulaciones
                linea = texto.Split(separador.ToCharArray());

                //completa las variables según cada tabulación
                id = int.Parse(linea[0]);
                usuario = linea[1];
                clave = linea[2];

                //crea el objeto, y lo carga en la lista
                nuevoUsuario = new Usuario(id, usuario, clave);
                lista.Add(nuevoUsuario);
            }
        }

        static void CargarProductos(List<Producto> lista)
        {
            //variables de configuración
            string ubicacion = $"C:\\ComidaRapida\\productos.txt";
            string texto = "";
            string[] linea;
            string separador = "\t";

            //inicialización de variables
            int id, stock;
            string nombre;
            float precio;
            Producto nuevoProducto;

            //comienzo de lectura línea por línea
            StreamReader sr = new StreamReader(ubicacion);
            while (true)
            {
                texto = sr.ReadLine();

                //sale cuando no quedan líneas por leer
                if (texto == null || texto == "")
                {
                    break;
                }

                //divide la línea en tabulaciones
                linea = texto.Split(separador.ToCharArray());

                //completa las variables según cada tabulación
                id = int.Parse(linea[0]);
                nombre = linea[1];
                stock = int.Parse(linea[2]);
                precio = float.Parse(linea[3]);

                //crea el objeto, y lo carga en la lista
                nuevoProducto = new Producto(id, nombre, stock, precio);
                lista.Add(nuevoProducto);
            }
        }

        static void CargarPedidos(List<Pedido> listaPedidos, List<Usuario> listaUsuarios, List<Producto> listaProductos)
        {
            //variables de configuración
            string ubicacion = $"C:\\ComidaRapida\\pedidos.txt";
            string texto = "";
            string[] linea;
            string separador = "\t";

            //inicialización de variables
            int numero = 0; //valor placeholder
            DateTime fechaHora = new DateTime(); //valor placeholder
            List<DetallePedido> detalle = new List<DetallePedido>();
            Usuario usuario = new Usuario(0, "", ""); //valor placeholder
            Pago pago = new PagoEfectivo(0,0,0); //valor placeholder
            Pedido nuevoPedido;

            Producto prod;
            int cantProd;
            float precioProd;
            DetallePedido dp;

            //comienzo de lectura línea por línea
            StreamReader sr = new StreamReader(ubicacion);
            while (true)
            {
                texto = sr.ReadLine();

                //sale cuando no quedan líneas por leer
                if (texto == null)
                {
                    break;
                }

                //divide la línea en tabulaciones
                linea = texto.Split(separador.ToCharArray());

                //completa las variables según cada tabulación
                if (linea[0] == "pedido")
                {
                    numero = int.Parse(linea[1]);
                    foreach (Usuario us in listaUsuarios)
                    {
                        if (us.GetId() == int.Parse(linea[2]))
                        {
                            usuario = us;
                            break;
                        }
                    }
                    fechaHora = DateTime.Parse(linea[3]);
                    if (linea[4] == "efectivo")
                    {
                        pago = new PagoEfectivo(float.Parse(linea[5]), float.Parse(linea[6]), float.Parse(linea[7]));
                    }
                    else if (linea [4] == "tarjeta")
                    {
                        pago = new PagoTarjeta(float.Parse(linea[5]), linea[6], linea[7]);
                    }
                }
                else if (linea [0] == "detalle")
                {
                    prod = new Producto();
                    foreach (Producto pr in listaProductos)
                    {
                        if (pr.GetId() == int.Parse(linea[1]))
                        {
                            prod = pr;
                        }
                    }
                    cantProd = int.Parse(linea[2]);
                    precioProd = float.Parse(linea[3]);
                    dp = new DetallePedido(prod, cantProd, precioProd);
                    detalle.Add(dp);
                }
                else if (linea [0] == "fin pedido")
                {
                    try
                    {
                        //crea el objeto, y lo carga en la lista
                        nuevoPedido = new Pedido(numero, usuario, fechaHora, pago, detalle);
                        listaPedidos.Add(nuevoPedido);
                    } catch (Exception e)
                    {
                        var txt = "Error al cargar pedidos guardados.";
                        txt += "\n" + e.Message;
                        MessageBox.Show(txt);
                    }
                    detalle = new List<DetallePedido>();
                }
            }
        }
    }
}
