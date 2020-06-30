namespace NutriApp
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accederAlSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proximasCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proximaCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajusteDeAgendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaContactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoContactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeNutriAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeNutriAppToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDeNutriAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accederAlSistemaToolStripMenuItem,
            this.citasToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.contactosToolStripMenuItem,
            this.acercaDeNutriAppToolStripMenuItem,
            this.salirDeNutriAppToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(919, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accederAlSistemaToolStripMenuItem
            // 
            this.accederAlSistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asistenteToolStripMenuItem,
            this.asistenteToolStripMenuItem1});
            this.accederAlSistemaToolStripMenuItem.Image = global::NutriApp.Properties.Resources.VerSimilares;
            this.accederAlSistemaToolStripMenuItem.Name = "accederAlSistemaToolStripMenuItem";
            this.accederAlSistemaToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.accederAlSistemaToolStripMenuItem.Text = "Acceder al sistema";
            // 
            // asistenteToolStripMenuItem
            // 
            this.asistenteToolStripMenuItem.Name = "asistenteToolStripMenuItem";
            this.asistenteToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.asistenteToolStripMenuItem.Text = "Login";
            this.asistenteToolStripMenuItem.Click += new System.EventHandler(this.asistenteToolStripMenuItem_Click);
            // 
            // asistenteToolStripMenuItem1
            // 
            this.asistenteToolStripMenuItem1.Name = "asistenteToolStripMenuItem1";
            this.asistenteToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.asistenteToolStripMenuItem1.Text = "Registrarse";
            this.asistenteToolStripMenuItem1.Click += new System.EventHandler(this.asistenteToolStripMenuItem1_Click);
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarCitasToolStripMenuItem,
            this.proximasCitasToolStripMenuItem,
            this.cancelarCitasToolStripMenuItem});
            this.citasToolStripMenuItem.Image = global::NutriApp.Properties.Resources.reporte;
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.citasToolStripMenuItem.Text = "Citas";
            // 
            // agendarCitasToolStripMenuItem
            // 
            this.agendarCitasToolStripMenuItem.Name = "agendarCitasToolStripMenuItem";
            this.agendarCitasToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.agendarCitasToolStripMenuItem.Text = "Agendar Cita";
            this.agendarCitasToolStripMenuItem.Click += new System.EventHandler(this.agendarCitasToolStripMenuItem_Click);
            // 
            // proximasCitasToolStripMenuItem
            // 
            this.proximasCitasToolStripMenuItem.Name = "proximasCitasToolStripMenuItem";
            this.proximasCitasToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.proximasCitasToolStripMenuItem.Text = "Proximas Cita";
            this.proximasCitasToolStripMenuItem.Click += new System.EventHandler(this.proximasCitasToolStripMenuItem_Click);
            // 
            // cancelarCitasToolStripMenuItem
            // 
            this.cancelarCitasToolStripMenuItem.Name = "cancelarCitasToolStripMenuItem";
            this.cancelarCitasToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.cancelarCitasToolStripMenuItem.Text = "Cancelar Cita";
            this.cancelarCitasToolStripMenuItem.Click += new System.EventHandler(this.cancelarCitasToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proximaCitaToolStripMenuItem,
            this.ajusteDeAgendaToolStripMenuItem});
            this.consultasToolStripMenuItem.Image = global::NutriApp.Properties.Resources.Historial;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // proximaCitaToolStripMenuItem
            // 
            this.proximaCitaToolStripMenuItem.Name = "proximaCitaToolStripMenuItem";
            this.proximaCitaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.proximaCitaToolStripMenuItem.Text = "Proxima Cita";
            // 
            // ajusteDeAgendaToolStripMenuItem
            // 
            this.ajusteDeAgendaToolStripMenuItem.Name = "ajusteDeAgendaToolStripMenuItem";
            this.ajusteDeAgendaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ajusteDeAgendaToolStripMenuItem.Text = "Ajuste de Agenda";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPacienteToolStripMenuItem,
            this.actualizacionToolStripMenuItem,
            this.progresoToolStripMenuItem,
            this.archivoToolStripMenuItem});
            this.pacientesToolStripMenuItem.Image = global::NutriApp.Properties.Resources.ic_action_user;
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // nuevoPacienteToolStripMenuItem
            // 
            this.nuevoPacienteToolStripMenuItem.Name = "nuevoPacienteToolStripMenuItem";
            this.nuevoPacienteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.nuevoPacienteToolStripMenuItem.Text = "Nuevo Paciente";
            this.nuevoPacienteToolStripMenuItem.Click += new System.EventHandler(this.nuevoPacienteToolStripMenuItem_Click);
            // 
            // actualizacionToolStripMenuItem
            // 
            this.actualizacionToolStripMenuItem.Name = "actualizacionToolStripMenuItem";
            this.actualizacionToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.actualizacionToolStripMenuItem.Text = "Actualizacion";
            this.actualizacionToolStripMenuItem.Click += new System.EventHandler(this.actualizacionToolStripMenuItem_Click);
            // 
            // progresoToolStripMenuItem
            // 
            this.progresoToolStripMenuItem.Name = "progresoToolStripMenuItem";
            this.progresoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.progresoToolStripMenuItem.Text = "Progreso";
            this.progresoToolStripMenuItem.Click += new System.EventHandler(this.progresoToolStripMenuItem_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // contactosToolStripMenuItem
            // 
            this.contactosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaContactosToolStripMenuItem,
            this.nuevoContactoToolStripMenuItem});
            this.contactosToolStripMenuItem.Image = global::NutriApp.Properties.Resources.ic_action_user_add;
            this.contactosToolStripMenuItem.Name = "contactosToolStripMenuItem";
            this.contactosToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.contactosToolStripMenuItem.Text = "Contactos";
            // 
            // listaContactosToolStripMenuItem
            // 
            this.listaContactosToolStripMenuItem.Name = "listaContactosToolStripMenuItem";
            this.listaContactosToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.listaContactosToolStripMenuItem.Text = "Lista Contactos";
            this.listaContactosToolStripMenuItem.Click += new System.EventHandler(this.listaContactosToolStripMenuItem_Click);
            // 
            // nuevoContactoToolStripMenuItem
            // 
            this.nuevoContactoToolStripMenuItem.Name = "nuevoContactoToolStripMenuItem";
            this.nuevoContactoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.nuevoContactoToolStripMenuItem.Text = "Nuevo Contacto";
            this.nuevoContactoToolStripMenuItem.Click += new System.EventHandler(this.nuevoContactoToolStripMenuItem_Click);
            // 
            // acercaDeNutriAppToolStripMenuItem
            // 
            this.acercaDeNutriAppToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeNutriAppToolStripMenuItem1});
            this.acercaDeNutriAppToolStripMenuItem.Image = global::NutriApp.Properties.Resources.procesar1;
            this.acercaDeNutriAppToolStripMenuItem.Name = "acercaDeNutriAppToolStripMenuItem";
            this.acercaDeNutriAppToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.acercaDeNutriAppToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeNutriAppToolStripMenuItem1
            // 
            this.acercaDeNutriAppToolStripMenuItem1.Name = "acercaDeNutriAppToolStripMenuItem1";
            this.acercaDeNutriAppToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.acercaDeNutriAppToolStripMenuItem1.Text = "Acerca de NutriApp";
            // 
            // salirDeNutriAppToolStripMenuItem
            // 
            this.salirDeNutriAppToolStripMenuItem.Image = global::NutriApp.Properties.Resources.salir_de_gnome_icono_8179_48;
            this.salirDeNutriAppToolStripMenuItem.Name = "salirDeNutriAppToolStripMenuItem";
            this.salirDeNutriAppToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.salirDeNutriAppToolStripMenuItem.Text = "Salir de NutriApp";
            this.salirDeNutriAppToolStripMenuItem.Click += new System.EventHandler(this.salirDeNutriAppToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NutriApp.Properties.Resources.NUTRICIÓN;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(919, 366);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenu";
            this.Text = "NutriApp - Software Nutricional";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accederAlSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeNutriAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDeNutriAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proximasCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proximaCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajusteDeAgendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeNutriAppToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaContactosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoContactoToolStripMenuItem;
    }
}

