using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidaRapida
{
    public class Usuario
    {
        int id;
        string nombre;
        string clave;

        public Usuario (int id, string nombre, string clave)
        {
            this.id = id;
            this.nombre = nombre;
            this.clave = clave;
        }

        public int GetId()
        {
            return id;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetClave()
        {
            return clave;
        }

        public override string ToString()
        {
            return $"{nombre}, {clave}";
        }
    }
}
