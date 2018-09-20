namespace RRHH
{
    partial class frmDepartamentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroEliminar = new MetroFramework.Controls.MetroButton();
            this.metroEditar = new MetroFramework.Controls.MetroButton();
            this.metroButtonGuardar = new MetroFramework.Controls.MetroButton();
            this.metroRadioEstado = new MetroFramework.Controls.MetroRadioButton();
            this.metroTextNombreDepartamento = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroGridDepartamentos = new MetroFramework.Controls.MetroGrid();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonBuscar = new MetroFramework.Controls.MetroButton();
            this.metroTextBuscar = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.White;
            this.metroPanel1.Controls.Add(this.metroEliminar);
            this.metroPanel1.Controls.Add(this.metroEditar);
            this.metroPanel1.Controls.Add(this.metroButtonGuardar);
            this.metroPanel1.Controls.Add(this.metroRadioEstado);
            this.metroPanel1.Controls.Add(this.metroTextNombreDepartamento);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(24, 84);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(506, 108);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroEliminar
            // 
            this.metroEliminar.Location = new System.Drawing.Point(397, 61);
            this.metroEliminar.Name = "metroEliminar";
            this.metroEliminar.Size = new System.Drawing.Size(75, 23);
            this.metroEliminar.TabIndex = 9;
            this.metroEliminar.Text = "Eliminar";
            this.metroEliminar.UseSelectable = true;
            this.metroEliminar.Click += new System.EventHandler(this.metroEliminar_Click);
            // 
            // metroEditar
            // 
            this.metroEditar.Location = new System.Drawing.Point(397, 32);
            this.metroEditar.Name = "metroEditar";
            this.metroEditar.Size = new System.Drawing.Size(75, 23);
            this.metroEditar.TabIndex = 8;
            this.metroEditar.Text = "Editar";
            this.metroEditar.UseSelectable = true;
            this.metroEditar.Click += new System.EventHandler(this.metroEditar_Click);
            // 
            // metroButtonGuardar
            // 
            this.metroButtonGuardar.Location = new System.Drawing.Point(397, 3);
            this.metroButtonGuardar.Name = "metroButtonGuardar";
            this.metroButtonGuardar.Size = new System.Drawing.Size(75, 23);
            this.metroButtonGuardar.TabIndex = 7;
            this.metroButtonGuardar.Text = "Guardar";
            this.metroButtonGuardar.UseSelectable = true;
            this.metroButtonGuardar.Click += new System.EventHandler(this.metroButtonGuardar_Click);
            // 
            // metroRadioEstado
            // 
            this.metroRadioEstado.AutoSize = true;
            this.metroRadioEstado.Location = new System.Drawing.Point(100, 75);
            this.metroRadioEstado.Name = "metroRadioEstado";
            this.metroRadioEstado.Size = new System.Drawing.Size(104, 15);
            this.metroRadioEstado.TabIndex = 6;
            this.metroRadioEstado.Text = "Activo/Inactivo";
            this.metroRadioEstado.UseSelectable = true;
            // 
            // metroTextNombreDepartamento
            // 
            // 
            // 
            // 
            this.metroTextNombreDepartamento.CustomButton.Image = null;
            this.metroTextNombreDepartamento.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.metroTextNombreDepartamento.CustomButton.Name = "";
            this.metroTextNombreDepartamento.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextNombreDepartamento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextNombreDepartamento.CustomButton.TabIndex = 1;
            this.metroTextNombreDepartamento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextNombreDepartamento.CustomButton.UseSelectable = true;
            this.metroTextNombreDepartamento.CustomButton.Visible = false;
            this.metroTextNombreDepartamento.Lines = new string[0];
            this.metroTextNombreDepartamento.Location = new System.Drawing.Point(100, 20);
            this.metroTextNombreDepartamento.MaxLength = 32767;
            this.metroTextNombreDepartamento.Name = "metroTextNombreDepartamento";
            this.metroTextNombreDepartamento.PasswordChar = '\0';
            this.metroTextNombreDepartamento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextNombreDepartamento.SelectedText = "";
            this.metroTextNombreDepartamento.SelectionLength = 0;
            this.metroTextNombreDepartamento.SelectionStart = 0;
            this.metroTextNombreDepartamento.ShortcutsEnabled = true;
            this.metroTextNombreDepartamento.Size = new System.Drawing.Size(163, 23);
            this.metroTextNombreDepartamento.TabIndex = 4;
            this.metroTextNombreDepartamento.UseSelectable = true;
            this.metroTextNombreDepartamento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextNombreDepartamento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(16, 75);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Estado";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nombre";
            // 
            // metroGridDepartamentos
            // 
            this.metroGridDepartamentos.AllowUserToResizeRows = false;
            this.metroGridDepartamentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridDepartamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridDepartamentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridDepartamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridDepartamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridDepartamentos.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridDepartamentos.EnableHeadersVisualStyles = false;
            this.metroGridDepartamentos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridDepartamentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridDepartamentos.Location = new System.Drawing.Point(24, 277);
            this.metroGridDepartamentos.Name = "metroGridDepartamentos";
            this.metroGridDepartamentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridDepartamentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridDepartamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridDepartamentos.Size = new System.Drawing.Size(506, 150);
            this.metroGridDepartamentos.TabIndex = 1;
            this.metroGridDepartamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridDepartamentos_CellContentClick);
            this.metroGridDepartamentos.SelectionChanged += new System.EventHandler(this.metroGridDepartamentos_SelectionChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 252);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Departamentos";
            // 
            // metroButtonBuscar
            // 
            this.metroButtonBuscar.Location = new System.Drawing.Point(390, 247);
            this.metroButtonBuscar.Name = "metroButtonBuscar";
            this.metroButtonBuscar.Size = new System.Drawing.Size(75, 23);
            this.metroButtonBuscar.TabIndex = 3;
            this.metroButtonBuscar.Text = "Buscar";
            this.metroButtonBuscar.UseSelectable = true;
            this.metroButtonBuscar.Click += new System.EventHandler(this.metroButtonBuscar_Click);
            // 
            // metroTextBuscar
            // 
            // 
            // 
            // 
            this.metroTextBuscar.CustomButton.Image = null;
            this.metroTextBuscar.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.metroTextBuscar.CustomButton.Name = "";
            this.metroTextBuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBuscar.CustomButton.TabIndex = 1;
            this.metroTextBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBuscar.CustomButton.UseSelectable = true;
            this.metroTextBuscar.CustomButton.Visible = false;
            this.metroTextBuscar.Lines = new string[0];
            this.metroTextBuscar.Location = new System.Drawing.Point(154, 247);
            this.metroTextBuscar.MaxLength = 32767;
            this.metroTextBuscar.Name = "metroTextBuscar";
            this.metroTextBuscar.PasswordChar = '\0';
            this.metroTextBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBuscar.SelectedText = "";
            this.metroTextBuscar.SelectionLength = 0;
            this.metroTextBuscar.SelectionStart = 0;
            this.metroTextBuscar.ShortcutsEnabled = true;
            this.metroTextBuscar.Size = new System.Drawing.Size(217, 23);
            this.metroTextBuscar.TabIndex = 4;
            this.metroTextBuscar.UseSelectable = true;
            this.metroTextBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.metroTextBuscar);
            this.Controls.Add(this.metroButtonBuscar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroGridDepartamentos);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmDepartamentos";
            this.Text = "Departamentos";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.FormDepartamentos_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridDepartamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroRadioButton metroRadioEstado;
        private MetroFramework.Controls.MetroTextBox metroTextNombreDepartamento;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid metroGridDepartamentos;
        private MetroFramework.Controls.MetroButton metroEliminar;
        private MetroFramework.Controls.MetroButton metroEditar;
        private MetroFramework.Controls.MetroButton metroButtonGuardar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButtonBuscar;
        private MetroFramework.Controls.MetroTextBox metroTextBuscar;
    }
}

