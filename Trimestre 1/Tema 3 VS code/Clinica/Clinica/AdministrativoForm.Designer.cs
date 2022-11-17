namespace Clinica
{
    partial class AdministrativoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrativoForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centroDeDíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BuscarPacientetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CrearPacientetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EliminarPacientetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.VerFichaPacientetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SacarEtiquetasPacientetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.centroDeDíaToolStripMenuItem,
            this.citaToolStripMenuItem,
            this.guardarActividadToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // centroDeDíaToolStripMenuItem
            // 
            this.centroDeDíaToolStripMenuItem.Name = "centroDeDíaToolStripMenuItem";
            this.centroDeDíaToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.centroDeDíaToolStripMenuItem.Text = "Centro de día";
            this.centroDeDíaToolStripMenuItem.Click += new System.EventHandler(this.centroDeDíaToolStripMenuItem_Click);
            // 
            // citaToolStripMenuItem
            // 
            this.citaToolStripMenuItem.Name = "citaToolStripMenuItem";
            this.citaToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.citaToolStripMenuItem.Text = "Cita";
            this.citaToolStripMenuItem.Click += new System.EventHandler(this.citaToolStripMenuItem_Click);
            // 
            // guardarActividadToolStripMenuItem
            // 
            this.guardarActividadToolStripMenuItem.Name = "guardarActividadToolStripMenuItem";
            this.guardarActividadToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.guardarActividadToolStripMenuItem.Text = "Guardar actividad";
            this.guardarActividadToolStripMenuItem.Click += new System.EventHandler(this.guardarActividadToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuscarPacientetoolStripButton,
            this.CrearPacientetoolStripButton,
            this.EliminarPacientetoolStripButton,
            this.VerFichaPacientetoolStripButton,
            this.SacarEtiquetasPacientetoolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // BuscarPacientetoolStripButton
            // 
            this.BuscarPacientetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BuscarPacientetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarPacientetoolStripButton.Image")));
            this.BuscarPacientetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BuscarPacientetoolStripButton.Name = "BuscarPacientetoolStripButton";
            this.BuscarPacientetoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.BuscarPacientetoolStripButton.Text = "toolStripButton";
            // 
            // CrearPacientetoolStripButton
            // 
            this.CrearPacientetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CrearPacientetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CrearPacientetoolStripButton.Image")));
            this.CrearPacientetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CrearPacientetoolStripButton.Name = "CrearPacientetoolStripButton";
            this.CrearPacientetoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CrearPacientetoolStripButton.Text = "CrearPaciente";
            this.CrearPacientetoolStripButton.Click += new System.EventHandler(this.CrearPacientetoolStripButton_Click);
            // 
            // EliminarPacientetoolStripButton
            // 
            this.EliminarPacientetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EliminarPacientetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarPacientetoolStripButton.Image")));
            this.EliminarPacientetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EliminarPacientetoolStripButton.Name = "EliminarPacientetoolStripButton";
            this.EliminarPacientetoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.EliminarPacientetoolStripButton.Text = "toolStripButton3";
            // 
            // VerFichaPacientetoolStripButton
            // 
            this.VerFichaPacientetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.VerFichaPacientetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("VerFichaPacientetoolStripButton.Image")));
            this.VerFichaPacientetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VerFichaPacientetoolStripButton.Name = "VerFichaPacientetoolStripButton";
            this.VerFichaPacientetoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.VerFichaPacientetoolStripButton.Text = "toolStripButton4";
            // 
            // SacarEtiquetasPacientetoolStripButton
            // 
            this.SacarEtiquetasPacientetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SacarEtiquetasPacientetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SacarEtiquetasPacientetoolStripButton.Image")));
            this.SacarEtiquetasPacientetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SacarEtiquetasPacientetoolStripButton.Name = "SacarEtiquetasPacientetoolStripButton";
            this.SacarEtiquetasPacientetoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SacarEtiquetasPacientetoolStripButton.Text = "toolStripButton5";
            // 
            // AdministrativoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdministrativoForm";
            this.Text = "Administrativo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centroDeDíaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BuscarPacientetoolStripButton;
        private System.Windows.Forms.ToolStripButton CrearPacientetoolStripButton;
        private System.Windows.Forms.ToolStripButton EliminarPacientetoolStripButton;
        private System.Windows.Forms.ToolStripButton VerFichaPacientetoolStripButton;
        private System.Windows.Forms.ToolStripButton SacarEtiquetasPacientetoolStripButton;
    }
}