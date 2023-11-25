using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidaRapida
{
    public class Producto
    {
        int id;
        string nombre;
        int stock;
        float precio;

        public Producto(int id, string nombre, int stock, float precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.stock = stock;
            this.precio = precio;
        }

        public Producto(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public Producto()
        {
        }

        public int GetId()
        {
            return id;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetStock()
        {
            return stock;
        }

        public float GetPrecio()
        {
            return precio;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetStock(int stock)
        {
            this.stock = stock;
        }

        public void SetPrecio(float precio)
        {
            this.precio = precio;
        }

        public void AddStock(int stock)
        {
            this.stock += stock;
        }

        public override string ToString()
        {
            return $"#{id} {nombre}, ${precio}, cant: {stock}";
        }
    }
}
