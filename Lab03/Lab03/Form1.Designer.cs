namespace Lab03
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDieta = new System.Windows.Forms.TextBox();
            this.tbHabitat = new System.Windows.Forms.TextBox();
            this.tbPeso = new System.Windows.Forms.TextBox();
            this.tbEspecie = new System.Windows.Forms.TextBox();
            this.dgAnimales = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnimales)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "NOMBRE:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "DIETA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "HÁBITAT:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "PESO:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "ESPECIE:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(27, 193);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(80, 23);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(113, 193);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(87, 25);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(223, 20);
            this.tbNombre.TabIndex = 7;
            // 
            // tbDieta
            // 
            this.tbDieta.Location = new System.Drawing.Point(87, 148);
            this.tbDieta.Name = "tbDieta";
            this.tbDieta.Size = new System.Drawing.Size(223, 20);
            this.tbDieta.TabIndex = 8;
            // 
            // tbHabitat
            // 
            this.tbHabitat.Location = new System.Drawing.Point(87, 116);
            this.tbHabitat.Name = "tbHabitat";
            this.tbHabitat.Size = new System.Drawing.Size(223, 20);
            this.tbHabitat.TabIndex = 9;
            // 
            // tbPeso
            // 
            this.tbPeso.Location = new System.Drawing.Point(87, 85);
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(223, 20);
            this.tbPeso.TabIndex = 10;
            // 
            // tbEspecie
            // 
            this.tbEspecie.Location = new System.Drawing.Point(87, 54);
            this.tbEspecie.Name = "tbEspecie";
            this.tbEspecie.Size = new System.Drawing.Size(223, 20);
            this.tbEspecie.TabIndex = 11;
            // 
            // dgAnimales
            // 
            this.dgAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnimales.Location = new System.Drawing.Point(27, 237);
            this.dgAnimales.Name = "dgAnimales";
            this.dgAnimales.Size = new System.Drawing.Size(646, 280);
            this.dgAnimales.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "MODIFICAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(820, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgAnimales);
            this.Controls.Add(this.tbEspecie);
            this.Controls.Add(this.tbPeso);
            this.Controls.Add(this.tbHabitat);
            this.Controls.Add(this.tbDieta);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "Form1";
            this.Text = "Animales";
            ((System.ComponentModel.ISupportInitialize)(this.dgAnimales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDieta;
        private System.Windows.Forms.TextBox tbHabitat;
        private System.Windows.Forms.TextBox tbPeso;
        private System.Windows.Forms.TextBox tbEspecie;
        private System.Windows.Forms.DataGridView dgAnimales;
        private System.Windows.Forms.Button button1;
    }
}

