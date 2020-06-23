namespace NutriApp.frmCitas
{
    partial class frmProximaCita
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstListado = new System.Windows.Forms.DataGridView();
            this.lbNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opcionbes = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstListado)).BeginInit();
            this.Opcionbes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nutriologo(a)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPaciente);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 89);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(627, 51);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Final:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(370, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Inicial:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(4, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstListado);
            this.groupBox2.Location = new System.Drawing.Point(5, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(888, 290);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de Citas";
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
            this.lblFecha,
            this.lblHora,
            this.lblTelefono,
            this.lblEmail});
            this.lstListado.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstListado.Location = new System.Drawing.Point(3, 18);
            this.lstListado.Name = "lstListado";
            this.lstListado.RowHeadersWidth = 51;
            this.lstListado.RowTemplate.Height = 24;
            this.lstListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.lstListado.Size = new System.Drawing.Size(871, 255);
            this.lstListado.TabIndex = 0;
            // 
            // lbNombre
            // 
            this.lbNombre.HeaderText = "Nombre Paciente";
            this.lbNombre.MinimumWidth = 6;
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Width = 125;
            // 
            // lblFecha
            // 
            this.lblFecha.HeaderText = "Fecha";
            this.lblFecha.MinimumWidth = 6;
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Width = 125;
            // 
            // lblHora
            // 
            this.lblHora.HeaderText = "Hora";
            this.lblHora.MinimumWidth = 6;
            this.lblHora.Name = "lblHora";
            this.lblHora.Width = 125;
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
            // Opcionbes
            // 
            this.Opcionbes.Controls.Add(this.btnBuscar);
            this.Opcionbes.Controls.Add(this.btnVolver);
            this.Opcionbes.Location = new System.Drawing.Point(5, 386);
            this.Opcionbes.Name = "Opcionbes";
            this.Opcionbes.Size = new System.Drawing.Size(313, 88);
            this.Opcionbes.TabIndex = 3;
            this.Opcionbes.TabStop = false;
            this.Opcionbes.Text = "Opciones";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::NutriApp.Properties.Resources.lupa;
            this.btnBuscar.Location = new System.Drawing.Point(158, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(128, 43);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Image = global::NutriApp.Properties.Resources.Atras;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(11, 34);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(131, 43);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = " Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(181, 52);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(180, 22);
            this.txtPaciente.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Paciente:";
            // 
            // frmProximaCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(903, 482);
            this.Controls.Add(this.Opcionbes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProximaCita";
            this.Text = "Modulo - Listado de Proxima Citas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstListado)).EndInit();
            this.Opcionbes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView lstListado;
        private System.Windows.Forms.GroupBox Opcionbes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPaciente;
    }
}