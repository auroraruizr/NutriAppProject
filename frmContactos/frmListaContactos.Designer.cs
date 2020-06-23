namespace NutriApp.frmContactos
{
    partial class frmListaContactos
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstListado = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstListado)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Contacto:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(154, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(210, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Busqueda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstListado);
            this.groupBox2.Location = new System.Drawing.Point(6, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 318);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de Contactos";
            // 
            // lstListado
            // 
            this.lstListado.AllowUserToAddRows = false;
            this.lstListado.AllowUserToOrderColumns = true;
            this.lstListado.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstListado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lstListado.ColumnHeadersHeight = 29;
            this.lstListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.lstListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lbNombre,
            this.lblDireccion,
            this.lblTelefono,
            this.lblEmail});
            this.lstListado.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstListado.Location = new System.Drawing.Point(3, 18);
            this.lstListado.Name = "lstListado";
            this.lstListado.RowHeadersWidth = 51;
            this.lstListado.RowTemplate.Height = 24;
            this.lstListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.lstListado.Size = new System.Drawing.Size(554, 294);
            this.lstListado.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::NutriApp.Properties.Resources.lupa;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(154, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 44);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "      Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Image = global::NutriApp.Properties.Resources.Atras;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(6, 31);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(115, 44);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "   Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // lbNombre
            // 
            this.lbNombre.HeaderText = "Nombre Contacto";
            this.lbNombre.MinimumWidth = 6;
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Width = 125;
            // 
            // lblDireccion
            // 
            this.lblDireccion.HeaderText = "Direccion";
            this.lblDireccion.MinimumWidth = 6;
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Width = 125;
            // 
            // lblTelefono
            // 
            this.lblTelefono.HeaderText = "Telefono";
            this.lblTelefono.MinimumWidth = 6;
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Width = 125;
            // 
            // lblEmail
            // 
            this.lblEmail.HeaderText = "Email";
            this.lblEmail.MinimumWidth = 6;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVolver);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Location = new System.Drawing.Point(6, 408);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 91);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones";
            // 
            // frmListaContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(601, 503);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListaContactos";
            this.Text = "Modulo - Listado de Contactos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstListado)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView lstListado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblEmail;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}