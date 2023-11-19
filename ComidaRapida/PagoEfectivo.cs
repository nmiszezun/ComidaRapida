using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidaRapida
{
    public class PagoEfectivo : Pago
    {
        float efectivoRecibido;
        float vueltoEntregado;

        public PagoEfectivo (float importeTotal, float efectivoRecibido, float vueltoEntregado) : base(importeTotal)
        {
            this.efectivoRecibido = efectivoRecibido;
            this.vueltoEntregado = vueltoEntregado;
        }

        public float GetEfectivoRecibido ()
        {
            return efectivoRecibido;
        }

        public float GetVueltoEntregado ()
        {
            return vueltoEntregado;
        }
    }
}
