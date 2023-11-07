using Entidades;
using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraAsientosLibros
    {
        private Contexto contexto;
        private static ControladoraAsientosLibros instancia;

        private ControladoraAsientosLibros()
        {
            contexto = new Contexto();
        }

        public static ControladoraAsientosLibros Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraAsientosLibros();
                }
                return instancia;
            }
        }

        public IReadOnlyCollection<AsientoContable> ListarAsientosContables()
        {
            return contexto.AsientoContable.Include(a => a.LibroContable).Include(a => a.Concepto).ToList();
        }

        public string AgregarAsiento(AsientoContable item)
        {
            try
            {
                var listaAsientos = ListarAsientosContables();
                var asientoEncontrado = listaAsientos.FirstOrDefault(x => x.Codigo == item.Codigo);
                if (asientoEncontrado == null)
                {
                    contexto.AsientoContable.Add(item);
                    contexto.SaveChanges();
                    return $"Asiento contable {item.AsientoContableId} se agregó correctamente.";
                }
                else
                {
                    return $"El asiento contable {item.AsientoContableId} ya existe.";
                }
            }
            catch (Exception)
            {
                return "Error desconocido al intentar agregar el asiento contable.";
            }
        }

        public string EliminarAsiento(AsientoContable item)
        {
            try
            {
                contexto.AsientoContable.Remove(item);
                contexto.SaveChanges();
                return $"Asiento contable {item.AsientoContableId} se eliminó correctamente.";
            }
            catch (Exception)
            {
                return "Error desconocido al intentar eliminar el asiento contable.";
            }
        }


        public IReadOnlyCollection<LibroContable> ListarLibrosContables()
        {
            return contexto.LibroContable.ToList();
        }

        public LibroContable ObtenerLibroContablePorCodigo(string nombre)
        {
            var libro = ListarLibrosContables().FirstOrDefault(x => x.Codigo.ToLower() == nombre.ToLower());
            return libro;
        }

        public IReadOnlyCollection<Concepto> ListarConceptos()
        {
            return contexto.Concepto.ToList();
        }

        public Concepto ObtenerConceptoPorCodigo(string codigo)
        {
            var concepto = ListarConceptos().FirstOrDefault(x => x.Codigo.ToLower() == codigo.ToLower());
            return concepto;
        }


        public string AgregarLibro(LibroContable item)
        {
            try
            {
                var listaLibros = ListarLibrosContables();
                var libroEncontrado = listaLibros.FirstOrDefault(x => x.Codigo == item.Codigo);
                if (libroEncontrado == null)
                {
                    contexto.LibroContable.Add(item);
                    contexto.SaveChanges();
                    return $"Libro contable {item.LibroContableId} se agregó correctamente.";
                }
                else
                {
                    return $"El libro contable {item.LibroContableId} ya existe.";
                }
            }
            catch (Exception)
            {
                return "Error desconocido al intentar agregar el libro contable.";
            }
        }

        public string EliminarLibro(LibroContable item)
        {
            try
            {
                contexto.LibroContable.Remove(item);
                contexto.SaveChanges();
                return $"Libro contable {item.LibroContableId} se eliminó correctamente.";
            }
            catch (Exception)
            {
                return "Error desconocido al intentar eliminar el libro contable.";
            }
        }

        public string ModificarLibro(LibroContable item)
        {
            try
            {
                contexto.LibroContable.Update(item);
                contexto.SaveChanges();
                return $"Libro contable {item.LibroContableId} se modificó correctamente.";
            }
            catch (Exception)
            {
                return $"Error desconocido al intentar modificar el libro contable.";
            }
        }
    }
}
