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
            pago = new PagoEfectivo(0, 0, 0);
        }

        public Pedido (int numero, Usuario usuario, DateTime fechaHora, Pago pago, List<DetallePedido> detalle)
        {
            this.numero = numero;
            this.usuario = usuario;
            this.fechaHora = fechaHora;
            this.pago = pago;
            this.listaProductos = detalle;
        }

        public Pedido ()
        {
            listaProductos = new List<DetallePedido>();
            pago = new PagoEfectivo(0, 0, 0);
        }

        public int GetNumero()
        {
            return numero;
        }

        public void SetNumero (int numero)
        {
            this.numero = numero;
        }

        public Usuario GetUsuario()
        {
            return usuario;
        }

        public void SetUsuario (Usuario usuario)
        {
            this.usuario = usuario;
        }

        public string GetFechaHoraString()
        {
            return fechaHora.ToString();
        }

        public DateTime GetFechaHora()
        {
            return fechaHora;
        }

        public void SetFechaHora(DateTime fechaHora)
        {
            this.fechaHora = fechaHora;
        }

        public Pago GetPago ()
        {
            return pago;
        }

        public void SetPago (Pago pago)
        {
            this.pago = pago;
        }

        public List<DetallePedido> GetListaProductos()
        {
            return listaProductos;
        }

        public void AddProducto(Producto producto, int cantidad)
        {
            listaProductos.Add(new DetallePedido(producto, cantidad));
            pago.SetImporteTotal(pago.GetImporteTotal() + producto.GetPrecio() * cantidad);
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
