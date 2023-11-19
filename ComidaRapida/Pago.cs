using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidaRapida
{
    public abstract class Pago
    {
        float importeTotal;

        public Pago (float importeTotal)
        {
            this.importeTotal = importeTotal;
        }

        abstract public string GetPagoExport();

        public float GetImporteTotal()
        {
            return importeTotal;
        }
    }
}
