namespace Vista
{
    partial class Asientos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvLibrosContables = new DataGridView();
            btnAgregarAsiento = new Button();
            lblLibros = new Label();
            lblAsientos = new Label();
            dgvAsientosContablesAsociados = new DataGridView();
            btnEliminarAsiento = new Button();
            btnAgregarLibro = new Button();
            btnModificarLibro = new Button();
            btnEliminarLibro = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLibrosContables).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAsientosContablesAsociados).BeginInit();
            SuspendLayout();
            // 
            // dgvLibrosContables
            // 
            dgvLibrosContables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibrosContables.Location = new Point(12, 29);
            dgvLibrosContables.Name = "dgvLibrosContables";
            dgvLibrosContables.RowTemplate.Height = 25;
            dgvLibrosContables.Size = new Size(455, 212);
            dgvLibrosContables.TabIndex = 0;
            dgvLibrosContables.SelectionChanged += dgvLibrosContables_SelectionChanged;
            // 
            // btnAgregarAsiento
            // 
            btnAgregarAsiento.Location = new Point(493, 216);
            btnAgregarAsiento.Name = "btnAgregarAsiento";
            btnAgregarAsiento.Size = new Size(103, 23);
            btnAgregarAsiento.TabIndex = 1;
            btnAgregarAsiento.Text = "Agregar Asiento";
            btnAgregarAsiento.UseVisualStyleBackColor = true;
            btnAgregarAsiento.Click += btnAgregarAsiento_Click;
            // 
            // lblLibros
            // 
            lblLibros.AutoSize = true;
            lblLibros.Location = new Point(136, 9);
            lblLibros.Name = "lblLibros";
            lblLibros.Size = new Size(95, 15);
            lblLibros.TabIndex = 2;
            lblLibros.Text = "Libros Contables";
            // 
            // lblAsientos
            // 
            lblAsientos.AutoSize = true;
            lblAsientos.Location = new Point(570, 9);
            lblAsientos.Name = "lblAsientos";
            lblAsientos.Size = new Size(207, 15);
            lblAsientos.TabIndex = 3;
            lblAsientos.Text = "Asientos Contables Asociados al Libro";
            // 
            // dgvAsientosContablesAsociados
            // 
            dgvAsientosContablesAsociados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsientosContablesAsociados.Location = new Point(493, 29);
            dgvAsientosContablesAsociados.Name = "dgvAsientosContablesAsociados";
            dgvAsientosContablesAsociados.RowTemplate.Height = 25;
            dgvAsientosContablesAsociados.Size = new Size(393, 181);
            dgvAsientosContablesAsociados.TabIndex = 4;
            // 
            // btnEliminarAsiento
            // 
            btnEliminarAsiento.Location = new Point(783, 218);
            btnEliminarAsiento.Name = "btnEliminarAsiento";
            btnEliminarAsiento.Size = new Size(103, 23);
            btnEliminarAsiento.TabIndex = 5;
            btnEliminarAsiento.Text = "Eliminar Asiento";
            btnEliminarAsiento.UseVisualStyleBackColor = true;
            btnEliminarAsiento.Click += btnEliminarAsiento_Click;
            // 
            // btnAgregarLibro
            // 
            btnAgregarLibro.Location = new Point(12, 260);
            btnAgregarLibro.Name = "btnAgregarLibro";
            btnAgregarLibro.Size = new Size(90, 23);
            btnAgregarLibro.TabIndex = 6;
            btnAgregarLibro.Text = "Agregar Libro";
            btnAgregarLibro.UseVisualStyleBackColor = true;
            btnAgregarLibro.Click += btnAgregarLibro_Click;
            // 
            // btnModificarLibro
            // 
            btnModificarLibro.Location = new Point(213, 260);
            btnModificarLibro.Name = "btnModificarLibro";
            btnModificarLibro.Size = new Size(101, 23);
            btnModificarLibro.TabIndex = 7;
            btnModificarLibro.Text = "Modificar Libro";
            btnModificarLibro.UseVisualStyleBackColor = true;
            btnModificarLibro.Click += btnModificarLibro_Click;
            // 
            // btnEliminarLibro
            // 
            btnEliminarLibro.Location = new Point(377, 260);
            btnEliminarLibro.Name = "btnEliminarLibro";
            btnEliminarLibro.Size = new Size(90, 23);
            btnEliminarLibro.TabIndex = 8;
            btnEliminarLibro.Text = "Eliminar Libro";
            btnEliminarLibro.UseVisualStyleBackColor = true;
            btnEliminarLibro.Click += btnEliminarLibro_Click;
            // 
            // Asientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 295);
            Controls.Add(btnEliminarLibro);
            Controls.Add(btnModificarLibro);
            Controls.Add(btnAgregarLibro);
            Controls.Add(btnEliminarAsiento);
            Controls.Add(dgvAsientosContablesAsociados);
            Controls.Add(lblAsientos);
            Controls.Add(lblLibros);
            Controls.Add(btnAgregarAsiento);
            Controls.Add(dgvLibrosContables);
            Name = "Asientos";
            Text = "Asientos";
            Load += Asientos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLibrosContables).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAsientosContablesAsociados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLibrosContables;
        private Button btnAgregarAsiento;
        private Label lblLibros;
        private Label lblAsientos;
        private DataGridView dgvAsientosContablesAsociados;
        private Button btnEliminarAsiento;
        private Button btnAgregarLibro;
        private Button btnModificarLibro;
        private Button btnEliminarLibro;
    }
}