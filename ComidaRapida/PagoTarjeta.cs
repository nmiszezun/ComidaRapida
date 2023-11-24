using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidaRapida
{
    public class PagoTarjeta : Pago
    {
        string numero;
        string nombre;

        public PagoTarjeta(float importeTotal, string numero, string nombre) : base (importeTotal)
        {
            this.numero = numero;
            this.nombre = nombre;
        }

        public override string GetPagoExport ()
        {
            return "tarjeta\t" + GetImporteTotal() + "\t" + numero + "\t" + nombre;
        }

        public override string ToString()
        {
            return $"Tarjeta nro. {numero}, titular: {nombre}, importe: $ {GetImporteTotal()}";
        }
    }
}
