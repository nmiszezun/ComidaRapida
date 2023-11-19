using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidaRapida
{
    public class Pedido
    {
        int numero;
        DateTime fechaHora;
        List<DetallePedido> listaProductos;
        Usuario usuario;
        Pago pago;

        public Pedido (int numero, Usuario usuario)
        {
            this.numero = numero;
            fechaHora = DateTime.Now;
            listaProductos = new List<DetallePedido>();
            this.usuario = usuario;
        }

        public Pedido (int numero, Usuario usuario, DateTime fechaHora, Pago pago, List<DetallePedido> detalle)
        {
            this.numero = numero;
            this.usuario = usuario;
            this.fechaHora = fechaHora;
            this.pago = pago;
            this.listaProductos = detalle;
        }

        public int GetNumero()
        {
            return numero;
        }

        public string GetFechaHora()
        {
            return fechaHora.ToString();
        }

        public List<DetallePedido> GetListaProductos()
        {
            return listaProductos;
        }

        public void AddProducto(Producto producto, int cantidad)
        {
            //listaProductos.Add(producto);
        }

        public override string ToString()
        {
            string texto = "";
            texto += $"nro {numero} del {fechaHora} por {usuario.GetNombre()}";
            texto += "\n";
            texto += "detalle:\n";
            foreach (DetallePedido dp in listaProductos)
            {
                texto += dp.ToString() + "\n";
            }
            texto += "#####";
            return texto;
        }
    }
}
