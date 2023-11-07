using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AsientoContable
    {
        public enum TipoAsiento { Debe, Haber }

        public int AsientoContableId { get; set; }
        public string Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public TipoAsiento Tipo { get; set; }
        public Concepto Concepto { get; set; }
        public long Monto { get; set; }
        public LibroContable LibroContable { get; set; }

        public long ObtenerMonto()
        {
            if (Tipo == TipoAsiento.Debe)
            {
                return Monto;
            }
            else if (Tipo == TipoAsiento.Haber)
            {
                return -Monto;
            }
            else
            {
                throw new InvalidOperationException("Tipo de asiento no valido");
            }
        }

    }
}
