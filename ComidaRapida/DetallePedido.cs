using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidaRapida
{
    public class DetallePedido
    {
        Producto producto;
        int cantidad;
        float precio;

        public DetallePedido (Producto producto, int cantidad, float precio)
        {
            this.producto = producto;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public string GetProductoString ()
        {
            return producto.ToString();
        }

        public Producto GetProducto ()
        {
            return producto;
        }

        public int GetCantidad ()
        {
            return cantidad;
        }

        public float GetPrecio ()
        {
            return precio;
        }

        public override string ToString()
        {
            return $"{cantidad}x{producto.GetNombre()}, ${precio}";
        }
    }
}
