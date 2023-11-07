namespace Vista
{
    partial class AsientoAgregar
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
            lblAgregar = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            dtpFecha = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            numMonto = new NumericUpDown();
            label4 = new Label();
            cmbTipo = new ComboBox();
            label5 = new Label();
            cmbConcepto = new ComboBox();
            cmbLibro = new ComboBox();
            label6 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numMonto).BeginInit();
            SuspendLayout();
            // 
            // lblAgregar
            // 
            lblAgregar.AutoSize = true;
            lblAgregar.Location = new Point(197, 9);
            lblAgregar.Name = "lblAgregar";
            lblAgregar.Size = new Size(92, 15);
            lblAgregar.TabIndex = 0;
            lblAgregar.Text = "Agregar Asiento";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(71, 41);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(111, 23);
            txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "Codigo";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(260, 41);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(212, 23);
            dtpFecha.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 44);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "Monto";
            // 
            // numMonto
            // 
            numMonto.Location = new Point(62, 95);
            numMonto.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numMonto.Name = "numMonto";
            numMonto.Size = new Size(120, 23);
            numMonto.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(229, 97);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 8;
            label4.Text = "Tipo Asiento";
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(308, 94);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(145, 23);
            cmbTipo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 151);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 10;
            label5.Text = "Concepto";
            // 
            // cmbConcepto
            // 
            cmbConcepto.FormattingEnabled = true;
            cmbConcepto.Location = new Point(77, 148);
            cmbConcepto.Name = "cmbConcepto";
            cmbConcepto.Size = new Size(145, 23);
            cmbConcepto.TabIndex = 11;
            // 
            // cmbLibro
            // 
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(335, 148);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(145, 23);
            cmbLibro.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(244, 151);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 13;
            label6.Text = "Libro Contable";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 187);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(405, 187);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // AsientoAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 216);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label6);
            Controls.Add(cmbLibro);
            Controls.Add(cmbConcepto);
            Controls.Add(label5);
            Controls.Add(cmbTipo);
            Controls.Add(label4);
            Controls.Add(numMonto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpFecha);
            Controls.Add(label1);
            Controls.Add(txtCodigo);
            Controls.Add(lblAgregar);
            Name = "AsientoAgregar";
            Text = "AsientoAgregar";
            Load += AsientoAgregar_Load;
            ((System.ComponentModel.ISupportInitialize)numMonto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAgregar;
        private TextBox txtCodigo;
        private Label label1;
        private DateTimePicker dtpFecha;
        private Label label2;
        private Label label3;
        private NumericUpDown numMonto;
        private Label label4;
        private ComboBox cmbTipo;
        private Label label5;
        private ComboBox cmbConcepto;
        private ComboBox cmbLibro;
        private Label label6;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}