namespace Clinica
{
    partial class BuscarPacienteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNhc = new System.Windows.Forms.TextBox();
            this.txbDni = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lvPacientes = new System.Windows.Forms.ListView();
            this.chNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chApellidos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDireccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCodigoPostal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPoblacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNhc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI";
            // 
            // txbNhc
            // 
            this.txbNhc.Location = new System.Drawing.Point(130, 84);
            this.txbNhc.Name = "txbNhc";
            this.txbNhc.Size = new System.Drawing.Size(220, 20);
            this.txbNhc.TabIndex = 2;
            // 
            // txbDni
            // 
            this.txbDni.Location = new System.Drawing.Point(367, 84);
            this.txbDni.Name = "txbDni";
            this.txbDni.Size = new System.Drawing.Size(221, 20);
            this.txbDni.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(802, 78);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 28);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lvPacientes
            // 
            this.lvPacientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNombre,
            this.chApellidos,
            this.chDireccion,
            this.chCodigoPostal,
            this.chPoblacion,
            this.chDni,
            this.chNhc});
            this.lvPacientes.Enabled = false;
            this.lvPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPacientes.HideSelection = false;
            this.lvPacientes.Location = new System.Drawing.Point(26, 143);
            this.lvPacientes.Name = "lvPacientes";
            this.lvPacientes.Size = new System.Drawing.Size(1014, 295);
            this.lvPacientes.TabIndex = 5;
            this.lvPacientes.UseCompatibleStateImageBehavior = false;
            this.lvPacientes.View = System.Windows.Forms.View.Details;
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            this.chNombre.Width = 120;
            // 
            // chApellidos
            // 
            this.chApellidos.Text = "Apellidos";
            this.chApellidos.Width = 180;
            // 
            // chDireccion
            // 
            this.chDireccion.Text = "Direccion";
            this.chDireccion.Width = 160;
            // 
            // chCodigoPostal
            // 
            this.chCodigoPostal.Text = "CodigoPostal";
            this.chCodigoPostal.Width = 140;
            // 
            // chPoblacion
            // 
            this.chPoblacion.Text = "Poblacion";
            this.chPoblacion.Width = 140;
            // 
            // chDni
            // 
            this.chDni.Text = "Dni";
            this.chDni.Width = 170;
            // 
            // chNhc
            // 
            this.chNhc.Text = "Nhc";
            this.chNhc.Width = 100;
            // 
            // BuscarPacienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1122, 450);
            this.Controls.Add(this.lvPacientes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbDni);
            this.Controls.Add(this.txbNhc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BuscarPacienteForm";
            this.Text = "Buscar Paciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNhc;
        private System.Windows.Forms.TextBox txbDni;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListView lvPacientes;
        private System.Windows.Forms.ColumnHeader chNombre;
        private System.Windows.Forms.ColumnHeader chApellidos;
        private System.Windows.Forms.ColumnHeader chDireccion;
        private System.Windows.Forms.ColumnHeader chCodigoPostal;
        private System.Windows.Forms.ColumnHeader chPoblacion;
        private System.Windows.Forms.ColumnHeader chDni;
        private System.Windows.Forms.ColumnHeader chNhc;
    }
}