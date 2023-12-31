﻿using System;
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

        public override string GetPagoExport ()
        {
            return "efectivo\t" + GetImporteTotal() + "\t" + efectivoRecibido + "\t" + vueltoEntregado;
        }

        public override string ToString()
        {
            return $"Efectivo: $ {GetImporteTotal()} (Recibido: $ {efectivoRecibido}, vuelto: $ {vueltoEntregado})";
        }
    }
}
