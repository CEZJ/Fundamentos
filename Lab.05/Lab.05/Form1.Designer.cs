namespace Lab._05
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            tbCodigo = new TextBox();
            tbDireccion = new TextBox();
            tbGerente = new TextBox();
            tbPropiedad = new TextBox();
            tbArea = new TextBox();
            tbBuscar = new TextBox();
            btnBuscar = new Button();
            dgCine = new DataGridView();
            btnRegistrar = new Button();
            btnOrdenar = new Button();
            btnEliminar = new Button();
            label6 = new Label();
            lblTotalRegistros = new Label();
            label8 = new Label();
            btnLimpiar = new Button();
            tbSalas = new TextBox();
            btnNumeroDeSalas = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgCine).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 75);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 120);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "Direccion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 158);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 0;
            label3.Text = "Gerente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 202);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 0;
            label4.Text = "Propiedad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 244);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 0;
            label5.Text = "Area";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 369);
            label7.Name = "label7";
            label7.Size = new Size(120, 15);
            label7.TabIndex = 0;
            label7.Text = "Buscar por Propiedad";
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(90, 75);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(133, 23);
            tbCodigo.TabIndex = 1;
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(90, 120);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(133, 23);
            tbDireccion.TabIndex = 1;
            tbDireccion.TextChanged += tbDireccion_TextChanged;
            // 
            // tbGerente
            // 
            tbGerente.Location = new Point(90, 158);
            tbGerente.Name = "tbGerente";
            tbGerente.Size = new Size(133, 23);
            tbGerente.TabIndex = 1;
            tbGerente.TextChanged += tbGerente_TextChanged;
            // 
            // tbPropiedad
            // 
            tbPropiedad.Location = new Point(90, 202);
            tbPropiedad.Name = "tbPropiedad";
            tbPropiedad.Size = new Size(133, 23);
            tbPropiedad.TabIndex = 1;
            // 
            // tbArea
            // 
            tbArea.Location = new Point(90, 244);
            tbArea.Name = "tbArea";
            tbArea.Size = new Size(133, 23);
            tbArea.TabIndex = 1;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(135, 366);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(231, 23);
            tbBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(135, 404);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgCine
            // 
            dgCine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCine.Location = new Point(389, 54);
            dgCine.Name = "dgCine";
            dgCine.Size = new Size(633, 258);
            dgCine.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(19, 310);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(113, 302);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(98, 39);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = "Ordenar por Propiedad";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(239, 310);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(884, 404);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 4;
            label6.Text = "Total de Registros: ";
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.Location = new Point(995, 404);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(13, 15);
            lblTotalRegistros.TabIndex = 4;
            lblTotalRegistros.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaption;
            label8.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.InactiveCaptionText;
            label8.Location = new Point(19, 9);
            label8.Name = "label8";
            label8.Size = new Size(466, 31);
            label8.TabIndex = 5;
            label8.Text = "REGISTRO DE MANTENIMIENTOS CINES";
            label8.Click += label8_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(389, 318);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // tbSalas
            // 
            tbSalas.Location = new Point(303, 75);
            tbSalas.Name = "tbSalas";
            tbSalas.Size = new Size(63, 23);
            tbSalas.TabIndex = 1;
            // 
            // btnNumeroDeSalas
            // 
            btnNumeroDeSalas.AutoSize = true;
            btnNumeroDeSalas.Location = new Point(248, 78);
            btnNumeroDeSalas.Name = "btnNumeroDeSalas";
            btnNumeroDeSalas.Size = new Size(50, 15);
            btnNumeroDeSalas.TabIndex = 0;
            btnNumeroDeSalas.Text = "N°Salas:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(229, 252);
            label9.Name = "label9";
            label9.Size = new Size(24, 15);
            label9.TabIndex = 7;
            label9.Text = "m2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 450);
            Controls.Add(label9);
            Controls.Add(btnLimpiar);
            Controls.Add(label8);
            Controls.Add(lblTotalRegistros);
            Controls.Add(label6);
            Controls.Add(dgCine);
            Controls.Add(btnEliminar);
            Controls.Add(btnOrdenar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnBuscar);
            Controls.Add(tbBuscar);
            Controls.Add(tbArea);
            Controls.Add(tbPropiedad);
            Controls.Add(tbGerente);
            Controls.Add(tbDireccion);
            Controls.Add(tbSalas);
            Controls.Add(tbCodigo);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnNumeroDeSalas);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgCine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox tbCodigo;
        private TextBox tbDireccion;
        private TextBox tbGerente;
        private TextBox tbPropiedad;
        private TextBox tbArea;
        private TextBox tbBuscar;
        private Button btnBuscar;
        private DataGridView dgCine;
        private Button btnRegistrar;
        private Button btnOrdenar;
        private Button btnEliminar;
        private Label label6;
        private Label lblTotalRegistros;
        private Label label8;
        private Button btnLimpiar;
        private TextBox tbSalas;
        private Label btnNumeroDeSalas;
        private Label label9;
    }
}
