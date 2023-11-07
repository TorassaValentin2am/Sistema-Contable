using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LibroContable
    {
        public int LibroContableId { get; set; }
        public string Codigo { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }
        public List<AsientoContable> AsientosContables { get; set; }
        public long CapitalActual { get; set; }

        public LibroContable()
        {
              AsientosContables = new List<AsientoContable>();
        }

        public void AgregarAsientoContable(AsientoContable asiento)
        {
            AsientosContables.Add(asiento);
            ActualizarCapitalActual(asiento);
        }

        public void EliminarAsientoContable(AsientoContable asiento)
        {
            if (AsientosContables.Contains(asiento))
            {
                AsientosContables.Remove(asiento);
                ActualizarCapitalActualEliminar(asiento);
            }
        }

        private void ActualizarCapitalActual(AsientoContable asiento)
        {
            CapitalActual += asiento.ObtenerMonto();
        }

        private void ActualizarCapitalActualEliminar(AsientoContable asiento)
        {
            CapitalActual -= asiento.ObtenerMonto();
        }

        public override string ToString()
        {
            return Codigo;
        }
    }
}
