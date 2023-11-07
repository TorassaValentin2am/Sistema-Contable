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
    public partial class LibroAgregarModificar : Form
    {
        private LibroContable libro;
        private bool modificar = false;

        public LibroAgregarModificar()
        {
            InitializeComponent();
        }

        public LibroAgregarModificar(LibroContable libroModificar)
        {
            InitializeComponent();
            libro = libroModificar;
            modificar = true;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (modificar)
                {
                    libro.Codigo = txtCodigo.Text;
                    libro.Mes = (int)numMes.Value;
                    libro.Año = (int)numAño.Value;

                    var mensaje = ControladoraAsientosLibros.Instancia.ModificarLibro(libro);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    var nuevoLibro = new LibroContable()
                    {
                        Codigo = txtCodigo.Text,
                        Mes = (int)numMes.Value,
                        Año = (int)numAño.Value
                    };

                    var mensaje = ControladoraAsientosLibros.Instancia.AgregarLibro(nuevoLibro);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void LibroAgregarModificar_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                lblAgregarModificar.Text = "Modificar Libro Contable";
                txtCodigo.Text = libro.Codigo;
                numMes.Value = libro.Mes;
                numAño.Value = libro.Año;
            }
            else
            {
                lblAgregarModificar.Text = "Agregar Libro Contable";
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Debe ingresar un código.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
