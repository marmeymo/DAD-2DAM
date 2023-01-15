namespace Clinica
{
    partial class PersonalSanitarioForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verFichaPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sacarEtiquetasDelPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verActasClínicosDelPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacienteToolStripMenuItem,
            this.notasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarPacienteToolStripMenuItem,
            this.verFichaPacienteToolStripMenuItem,
            this.sacarEtiquetasDelPacienteToolStripMenuItem,
            this.verActasClínicosDelPacienteToolStripMenuItem});
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.pacienteToolStripMenuItem.Text = "Paciente";
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarNotaToolStripMenuItem,
            this.crearNotaToolStripMenuItem,
            this.modificarNotaToolStripMenuItem,
            this.eliminarNotaToolStripMenuItem});
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // buscarPacienteToolStripMenuItem
            // 
            this.buscarPacienteToolStripMenuItem.Name = "buscarPacienteToolStripMenuItem";
            this.buscarPacienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.buscarPacienteToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.buscarPacienteToolStripMenuItem.Text = "Buscar paciente";
            this.buscarPacienteToolStripMenuItem.Click += new System.EventHandler(this.buscarPacienteToolStripMenuItem_Click);
            // 
            // verFichaPacienteToolStripMenuItem
            // 
            this.verFichaPacienteToolStripMenuItem.Name = "verFichaPacienteToolStripMenuItem";
            this.verFichaPacienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.verFichaPacienteToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.verFichaPacienteToolStripMenuItem.Text = "Ver ficha paciente";
            this.verFichaPacienteToolStripMenuItem.Click += new System.EventHandler(this.verFichaPacienteToolStripMenuItem_Click);
            // 
            // sacarEtiquetasDelPacienteToolStripMenuItem
            // 
            this.sacarEtiquetasDelPacienteToolStripMenuItem.Name = "sacarEtiquetasDelPacienteToolStripMenuItem";
            this.sacarEtiquetasDelPacienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.sacarEtiquetasDelPacienteToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.sacarEtiquetasDelPacienteToolStripMenuItem.Text = "Sacar etiquetas del paciente";
            this.sacarEtiquetasDelPacienteToolStripMenuItem.Click += new System.EventHandler(this.sacarEtiquetasDelPacienteToolStripMenuItem_Click);
            // 
            // verActasClínicosDelPacienteToolStripMenuItem
            // 
            this.verActasClínicosDelPacienteToolStripMenuItem.Name = "verActasClínicosDelPacienteToolStripMenuItem";
            this.verActasClínicosDelPacienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.verActasClínicosDelPacienteToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.verActasClínicosDelPacienteToolStripMenuItem.Text = "Ver actas clínicos del paciente";
            this.verActasClínicosDelPacienteToolStripMenuItem.Click += new System.EventHandler(this.verActasClínicosDelPacienteToolStripMenuItem_Click);
            // 
            // buscarNotaToolStripMenuItem
            // 
            this.buscarNotaToolStripMenuItem.Name = "buscarNotaToolStripMenuItem";
            this.buscarNotaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.buscarNotaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.buscarNotaToolStripMenuItem.Text = "Buscar nota";
            this.buscarNotaToolStripMenuItem.Click += new System.EventHandler(this.buscarNotaToolStripMenuItem_Click);
            // 
            // crearNotaToolStripMenuItem
            // 
            this.crearNotaToolStripMenuItem.Name = "crearNotaToolStripMenuItem";
            this.crearNotaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.crearNotaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.crearNotaToolStripMenuItem.Text = "Crear nota";
            this.crearNotaToolStripMenuItem.Click += new System.EventHandler(this.crearNotaToolStripMenuItem_Click);
            // 
            // modificarNotaToolStripMenuItem
            // 
            this.modificarNotaToolStripMenuItem.Name = "modificarNotaToolStripMenuItem";
            this.modificarNotaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.modificarNotaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.modificarNotaToolStripMenuItem.Text = "Modificar nota";
            this.modificarNotaToolStripMenuItem.Click += new System.EventHandler(this.modificarNotaToolStripMenuItem_Click);
            // 
            // eliminarNotaToolStripMenuItem
            // 
            this.eliminarNotaToolStripMenuItem.Name = "eliminarNotaToolStripMenuItem";
            this.eliminarNotaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.eliminarNotaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.eliminarNotaToolStripMenuItem.Text = "Eliminar nota";
            this.eliminarNotaToolStripMenuItem.Click += new System.EventHandler(this.eliminarNotaToolStripMenuItem_Click);
            // 
            // PersonalSanitarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PersonalSanitarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonalSanitario";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verFichaPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sacarEtiquetasDelPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verActasClínicosDelPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}