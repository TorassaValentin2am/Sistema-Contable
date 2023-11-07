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

namespace Vista
{
    public partial class Asientos : Form
    {
        public Asientos()
        {
            InitializeComponent();
        }

        private void Asientos_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            ConfigurarDGVAsientosContables();
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            LibroAgregarModificar formLibroContable = new LibroAgregarModificar();
            formLibroContable.ShowDialog();
            ActualizarGrilla();
        }

        private void btnModificarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibrosContables.Rows.Count > 0)
            {
                var libroContable = (LibroContable)dgvLibrosContables.CurrentRow.DataBoundItem;
                LibroAgregarModificar formLibroContable = new LibroAgregarModificar(libroContable);
                formLibroContable.ShowDialog();
                ActualizarGrilla();
            }
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibrosContables.Rows.Count > 0)
            {
                var libroContable = (LibroContable)dgvLibrosContables.CurrentRow.DataBoundItem;
                var mensaje = ControladoraAsientosLibros.Instancia.EliminarLibro(libroContable);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarGrilla();
            }
        }

        private void ActualizarGrilla()
        {
            dgvLibrosContables.DataSource = null;
            dgvLibrosContables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibrosContables.DataSource = ControladoraAsientosLibros.Instancia.ListarLibrosContables();
            ControladoraAsientosLibros.Instancia.ListarAsientosContables();
        }


        private void CargarAsientosContablesLibro()
        {
            if (dgvLibrosContables.Rows.Count > 0 && dgvLibrosContables.SelectedRows.Count > 0)
            {
                dgvAsientosContablesAsociados.DataSource = null;
                dgvAsientosContablesAsociados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                var libroContable = (LibroContable)dgvLibrosContables.CurrentRow.DataBoundItem;
                dgvAsientosContablesAsociados.DataSource = libroContable.AsientosContables;
            }
        }

        private void ConfigurarDGVAsientosContables()
        {
            dgvAsientosContablesAsociados.DataSource = null;
            dgvAsientosContablesAsociados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgvLibrosContables.Rows.Count > 0)
            {
                var libroContable = (LibroContable)dgvLibrosContables.Rows[0].DataBoundItem;
                dgvAsientosContablesAsociados.DataSource = libroContable.AsientosContables;
            }
        }

        private void dgvLibrosContables_SelectionChanged(object sender, EventArgs e)
        {
            CargarAsientosContablesLibro();
        }

        private void btnAgregarAsiento_Click(object sender, EventArgs e)
        {
            if (dgvLibrosContables.Rows.Count > 0)
            {
                var libroContable = (LibroContable)dgvLibrosContables.CurrentRow.DataBoundItem;
                AsientoAgregar formAsientoAgregar = new AsientoAgregar(libroContable);
                formAsientoAgregar.ShowDialog();
                ActualizarGrilla();
                ConfigurarDGVAsientosContables();
            }
        }

        private void btnEliminarAsiento_Click(object sender, EventArgs e)
        {
            if (dgvLibrosContables.Rows.Count > 0)
            {
                var libroContable = (LibroContable)dgvLibrosContables.CurrentRow.DataBoundItem;
                var asientoContable = (AsientoContable)dgvAsientosContablesAsociados.CurrentRow.DataBoundItem;
                libroContable.EliminarAsientoContable(asientoContable);
                var mensaje = ControladoraAsientosLibros.Instancia.EliminarAsiento(asientoContable);               
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarGrilla();
                ConfigurarDGVAsientosContables();
            }
        }
    }
}
