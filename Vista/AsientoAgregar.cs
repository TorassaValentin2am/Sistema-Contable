using Controladora;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static Entidades.AsientoContable;

namespace Vista
{
    public partial class AsientoAgregar : Form
    {
        LibroContable libroContable;

        public AsientoAgregar(LibroContable libro)
        {
            InitializeComponent();
            libroContable = libro;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                var nuevoAsientoContable = new AsientoContable()
                {
                    Codigo = txtCodigo.Text,
                    Monto = (long)numMonto.Value,
                    Concepto = (Concepto)cmbConcepto.SelectedItem,
                    Tipo = (TipoAsiento)cmbTipo.SelectedItem,
                    LibroContable = (LibroContable)cmbLibro.SelectedItem,
                    Fecha = dtpFecha.Value
                };

                libroContable.AgregarAsientoContable(nuevoAsientoContable);
                var mensaje = ControladoraAsientosLibros.Instancia.AgregarAsiento(nuevoAsientoContable);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AsientoAgregar_Load(object sender, EventArgs e)
        {
            CargarCombos();
            LimitarMesAño();
        }

        private void CargarCombos()
        {
            cmbTipo.DataSource = null;
            cmbLibro.DataSource = null;
            cmbConcepto.DataSource = null;
            cmbTipo.DataSource = Enum.GetValues(typeof(AsientoContable.TipoAsiento));
            cmbLibro.DataSource = ControladoraAsientosLibros.Instancia.ListarLibrosContables();
            cmbConcepto.DataSource = ControladoraAsientosLibros.Instancia.ListarConceptos();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Debe ingresar un código", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LimitarMesAño()
        {
            int mes = libroContable.Mes;
            int año = libroContable.Año;
            int diasEnMes = DateTime.DaysInMonth(año, mes);

            dtpFecha.MinDate = new DateTime(año, mes, 1);
            dtpFecha.MaxDate = new DateTime(año, mes, diasEnMes);
        }
    }
}
