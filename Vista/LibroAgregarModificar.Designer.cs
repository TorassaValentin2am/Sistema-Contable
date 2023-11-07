namespace Vista
{
    partial class LibroAgregarModificar
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
            lblAgregarModificar = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            numMes = new NumericUpDown();
            label3 = new Label();
            label1 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            numAño = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numMes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAño).BeginInit();
            SuspendLayout();
            // 
            // lblAgregarModificar
            // 
            lblAgregarModificar.AutoSize = true;
            lblAgregarModificar.Location = new Point(128, 9);
            lblAgregarModificar.Name = "lblAgregarModificar";
            lblAgregarModificar.Size = new Size(113, 15);
            lblAgregarModificar.TabIndex = 1;
            lblAgregarModificar.Text = "Agregar o Modificar";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 146);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(295, 146);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // numMes
            // 
            numMes.Location = new Point(187, 91);
            numMes.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numMes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMes.Name = "numMes";
            numMes.Size = new Size(54, 23);
            numMes.TabIndex = 11;
            numMes.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 93);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 10;
            label3.Text = "Mes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 39);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 9;
            label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(60, 36);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(111, 23);
            txtCodigo.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 39);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 12;
            label2.Text = "Año";
            // 
            // numAño
            // 
            numAño.Location = new Point(275, 37);
            numAño.Maximum = new decimal(new int[] { 2023, 0, 0, 0 });
            numAño.Minimum = new decimal(new int[] { 1980, 0, 0, 0 });
            numAño.Name = "numAño";
            numAño.Size = new Size(83, 23);
            numAño.TabIndex = 13;
            numAño.Value = new decimal(new int[] { 1980, 0, 0, 0 });
            // 
            // LibroAgregarModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 183);
            Controls.Add(numAño);
            Controls.Add(label2);
            Controls.Add(numMes);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtCodigo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblAgregarModificar);
            Name = "LibroAgregarModificar";
            Text = "LibroAgregarModificar";
            Load += LibroAgregarModificar_Load;
            ((System.ComponentModel.ISupportInitialize)numMes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAño).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAgregarModificar;
        private Button btnAceptar;
        private Button btnCancelar;
        private NumericUpDown numMes;
        private Label label3;
        private Label label1;
        private TextBox txtCodigo;
        private Label label2;
        private NumericUpDown numAño;
    }
}