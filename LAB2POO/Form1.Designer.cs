namespace LAB2POO
{
    partial class FormPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFiltrarBusqueda = new System.Windows.Forms.ComboBox();
            this.dataGridViewListadoAlumnos = new System.Windows.Forms.DataGridView();
            this.buttonNuevoEstudiante = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(58, 71);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(226, 20);
            this.textBoxBuscar.TabIndex = 1;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filtrar busqueda por";
            // 
            // comboBoxFiltrarBusqueda
            // 
            this.comboBoxFiltrarBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltrarBusqueda.FormattingEnabled = true;
            this.comboBoxFiltrarBusqueda.Location = new System.Drawing.Point(396, 72);
            this.comboBoxFiltrarBusqueda.Name = "comboBoxFiltrarBusqueda";
            this.comboBoxFiltrarBusqueda.Size = new System.Drawing.Size(134, 21);
            this.comboBoxFiltrarBusqueda.TabIndex = 3;
            this.comboBoxFiltrarBusqueda.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltrarBusqueda_SelectedIndexChanged);
            // 
            // dataGridViewListadoAlumnos
            // 
            this.dataGridViewListadoAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListadoAlumnos.Location = new System.Drawing.Point(12, 113);
            this.dataGridViewListadoAlumnos.Name = "dataGridViewListadoAlumnos";
            this.dataGridViewListadoAlumnos.Size = new System.Drawing.Size(784, 185);
            this.dataGridViewListadoAlumnos.TabIndex = 4;
            // 
            // buttonNuevoEstudiante
            // 
            this.buttonNuevoEstudiante.Location = new System.Drawing.Point(682, 318);
            this.buttonNuevoEstudiante.Name = "buttonNuevoEstudiante";
            this.buttonNuevoEstudiante.Size = new System.Drawing.Size(114, 23);
            this.buttonNuevoEstudiante.TabIndex = 5;
            this.buttonNuevoEstudiante.Text = "Nuevo Estudiante";
            this.buttonNuevoEstudiante.UseVisualStyleBackColor = true;
            this.buttonNuevoEstudiante.Click += new System.EventHandler(this.buttonNuevoEstudiante_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 355);
            this.Controls.Add(this.buttonNuevoEstudiante);
            this.Controls.Add(this.dataGridViewListadoAlumnos);
            this.Controls.Add(this.comboBoxFiltrarBusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiantes";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFiltrarBusqueda;
        private System.Windows.Forms.DataGridView dataGridViewListadoAlumnos;
        private System.Windows.Forms.Button buttonNuevoEstudiante;
    }
}

