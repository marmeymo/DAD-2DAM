namespace Clinica
{
    partial class BorrarPacienteForm
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
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.lvPacientes = new System.Windows.Forms.ListView();
            this.chNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chApellidos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDireccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCodigoPostal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPoblacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNhc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbBuscar
            // 
            this.cbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Items.AddRange(new object[] {
            "NHC",
            "DNI"});
            this.cbBuscar.Location = new System.Drawing.Point(90, 39);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(121, 21);
            this.cbBuscar.TabIndex = 0;
            // 
            // txbBuscar
            // 
            this.txbBuscar.Location = new System.Drawing.Point(90, 96);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(178, 20);
            this.txbBuscar.TabIndex = 1;
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
            this.lvPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPacientes.FullRowSelect = true;
            this.lvPacientes.HideSelection = false;
            this.lvPacientes.Location = new System.Drawing.Point(33, 148);
            this.lvPacientes.Name = "lvPacientes";
            this.lvPacientes.Size = new System.Drawing.Size(1007, 290);
            this.lvPacientes.TabIndex = 2;
            this.lvPacientes.UseCompatibleStateImageBehavior = false;
            this.lvPacientes.View = System.Windows.Forms.View.Details;
            this.lvPacientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvPacientes_MouseClick);
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            this.chNombre.Width = 150;
            // 
            // chApellidos
            // 
            this.chApellidos.Text = "Apellidos";
            this.chApellidos.Width = 150;
            // 
            // chDireccion
            // 
            this.chDireccion.Text = "Direccion";
            this.chDireccion.Width = 150;
            // 
            // chCodigoPostal
            // 
            this.chCodigoPostal.Text = "CodigoPostal";
            this.chCodigoPostal.Width = 150;
            // 
            // chPoblacion
            // 
            this.chPoblacion.Text = "Poblacion";
            this.chPoblacion.Width = 150;
            // 
            // chDni
            // 
            this.chDni.Text = "DNI";
            this.chDni.Width = 150;
            // 
            // chNhc
            // 
            this.chNhc.Text = "NHC";
            this.chNhc.Width = 100;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(397, 67);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(82, 35);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // BorrarPacienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lvPacientes);
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.cbBuscar);
            this.Name = "BorrarPacienteForm";
            this.Text = "BorrarPaciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBuscar;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.ListView lvPacientes;
        private System.Windows.Forms.ColumnHeader chNombre;
        private System.Windows.Forms.ColumnHeader chApellidos;
        private System.Windows.Forms.ColumnHeader chDireccion;
        private System.Windows.Forms.ColumnHeader chCodigoPostal;
        private System.Windows.Forms.ColumnHeader chPoblacion;
        private System.Windows.Forms.ColumnHeader chDni;
        private System.Windows.Forms.ColumnHeader chNhc;
        private System.Windows.Forms.Button btnBuscar;
    }
}