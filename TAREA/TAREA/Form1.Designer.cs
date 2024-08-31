namespace TAREA
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
            cbTipoAuto = new ComboBox();
            dgAtenciones = new DataGridView();
            cbTipoServicio = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnRegistrar = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblTotalServicio1 = new Label();
            lblTotalServicio2 = new Label();
            lblTotalServicio3 = new Label();
            lblServicioMenorDemanda = new Label();
            lblPromedioServicio1 = new Label();
            label10 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgAtenciones).BeginInit();
            SuspendLayout();
            // 
            // cbTipoAuto
            // 
            cbTipoAuto.FormattingEnabled = true;
            cbTipoAuto.Items.AddRange(new object[] { "A", "C" });
            cbTipoAuto.Location = new Point(148, 24);
            cbTipoAuto.Name = "cbTipoAuto";
            cbTipoAuto.Size = new Size(121, 23);
            cbTipoAuto.TabIndex = 0;
            cbTipoAuto.SelectedIndexChanged += cbTipoAuto_SelectedIndexChanged;
            // 
            // dgAtenciones
            // 
            dgAtenciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAtenciones.Location = new Point(37, 143);
            dgAtenciones.Name = "dgAtenciones";
            dgAtenciones.Size = new Size(342, 190);
            dgAtenciones.TabIndex = 5;
            dgAtenciones.CellContentClick += dgAtenciones_CellContentClick;
            // 
            // cbTipoServicio
            // 
            cbTipoServicio.FormattingEnabled = true;
            cbTipoServicio.Items.AddRange(new object[] { "1", "2", "3" });
            cbTipoServicio.Location = new Point(148, 76);
            cbTipoServicio.Name = "cbTipoServicio";
            cbTipoServicio.Size = new Size(121, 23);
            cbTipoServicio.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 28);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 3;
            label1.Text = "Tipo Auto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 79);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 4;
            label2.Text = "Tipo Servicio:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(160, 105);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 353);
            label3.Name = "label3";
            label3.Size = new Size(137, 15);
            label3.TabIndex = 6;
            label3.Text = "Total Servicio 1 - Lavado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 379);
            label4.Name = "label4";
            label4.Size = new Size(148, 15);
            label4.TabIndex = 6;
            label4.Text = "Total Servicio 2 - Encerado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 428);
            label5.Name = "label5";
            label5.Size = new Size(164, 15);
            label5.TabIndex = 6;
            label5.Text = "Promedio Servicio 1 - Lavado:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 457);
            label6.Name = "label6";
            label6.Size = new Size(143, 15);
            label6.TabIndex = 6;
            label6.Text = "Servicio Menor Demanda:";
            // 
            // lblTotalServicio1
            // 
            lblTotalServicio1.AutoSize = true;
            lblTotalServicio1.Location = new Point(213, 353);
            lblTotalServicio1.Name = "lblTotalServicio1";
            lblTotalServicio1.Size = new Size(13, 15);
            lblTotalServicio1.TabIndex = 7;
            lblTotalServicio1.Text = "0";
            // 
            // lblTotalServicio2
            // 
            lblTotalServicio2.AutoSize = true;
            lblTotalServicio2.Location = new Point(213, 379);
            lblTotalServicio2.Name = "lblTotalServicio2";
            lblTotalServicio2.Size = new Size(13, 15);
            lblTotalServicio2.TabIndex = 7;
            lblTotalServicio2.Text = "0";
            // 
            // lblTotalServicio3
            // 
            lblTotalServicio3.AutoSize = true;
            lblTotalServicio3.Location = new Point(213, 406);
            lblTotalServicio3.Name = "lblTotalServicio3";
            lblTotalServicio3.Size = new Size(13, 15);
            lblTotalServicio3.TabIndex = 7;
            lblTotalServicio3.Text = "0";
            // 
            // lblServicioMenorDemanda
            // 
            lblServicioMenorDemanda.AutoSize = true;
            lblServicioMenorDemanda.Location = new Point(213, 457);
            lblServicioMenorDemanda.Name = "lblServicioMenorDemanda";
            lblServicioMenorDemanda.Size = new Size(12, 15);
            lblServicioMenorDemanda.TabIndex = 7;
            lblServicioMenorDemanda.Text = "-";
            // 
            // lblPromedioServicio1
            // 
            lblPromedioServicio1.AutoSize = true;
            lblPromedioServicio1.Location = new Point(213, 428);
            lblPromedioServicio1.Name = "lblPromedioServicio1";
            lblPromedioServicio1.Size = new Size(13, 15);
            lblPromedioServicio1.TabIndex = 7;
            lblPromedioServicio1.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(213, 455);
            label10.Name = "label10";
            label10.Size = new Size(13, 15);
            label10.TabIndex = 7;
            label10.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 406);
            label8.Name = "label8";
            label8.Size = new Size(140, 15);
            label8.TabIndex = 8;
            label8.Text = "Total Servicio 3 - Silicona:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 543);
            Controls.Add(label8);
            Controls.Add(lblServicioMenorDemanda);
            Controls.Add(label10);
            Controls.Add(lblPromedioServicio1);
            Controls.Add(lblTotalServicio3);
            Controls.Add(lblTotalServicio2);
            Controls.Add(lblTotalServicio1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnRegistrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbTipoServicio);
            Controls.Add(dgAtenciones);
            Controls.Add(cbTipoAuto);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgAtenciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbTipoAuto;
        private DataGridView dgAtenciones;
        private ComboBox cbTipoServicio;
        private Label label1;
        private Label label2;
        private Button btnRegistrar;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblTotalServicio1;
        private Label lblTotalServicio2;
        private Label lblTotalServicio3;
        private Label lblServicioMenorDemanda;
        private Label lblPromedioServicio1;
        private Label label10;
        private Label label8;
    }
}
