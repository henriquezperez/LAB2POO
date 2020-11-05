namespace LAB2POO
{
    partial class fmrNuevoEstudiante
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxDUI = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.comboBoxCarrera = new System.Windows.Forms.ComboBox();
            this.buttonGuardarAlumno = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUEVO ESTUDIANTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DUI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Carrera";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(87, 71);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(240, 20);
            this.textBoxNombre.TabIndex = 7;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(87, 98);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(240, 20);
            this.textBoxApellido.TabIndex = 8;
            // 
            // textBoxDUI
            // 
            this.textBoxDUI.Location = new System.Drawing.Point(87, 127);
            this.textBoxDUI.Name = "textBoxDUI";
            this.textBoxDUI.Size = new System.Drawing.Size(240, 20);
            this.textBoxDUI.TabIndex = 9;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(87, 155);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(240, 20);
            this.textBoxTelefono.TabIndex = 10;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(87, 188);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(240, 20);
            this.textBoxDireccion.TabIndex = 11;
            // 
            // comboBoxCarrera
            // 
            this.comboBoxCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCarrera.FormattingEnabled = true;
            this.comboBoxCarrera.Location = new System.Drawing.Point(87, 221);
            this.comboBoxCarrera.Name = "comboBoxCarrera";
            this.comboBoxCarrera.Size = new System.Drawing.Size(240, 21);
            this.comboBoxCarrera.TabIndex = 12;
            this.comboBoxCarrera.SelectedIndexChanged += new System.EventHandler(this.comboBoxCarrera_SelectedIndexChanged);
            // 
            // buttonGuardarAlumno
            // 
            this.buttonGuardarAlumno.AllowDrop = true;
            this.buttonGuardarAlumno.AutoEllipsis = true;
            this.buttonGuardarAlumno.Location = new System.Drawing.Point(30, 259);
            this.buttonGuardarAlumno.Name = "buttonGuardarAlumno";
            this.buttonGuardarAlumno.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardarAlumno.TabIndex = 13;
            this.buttonGuardarAlumno.Text = "Guardar";
            this.buttonGuardarAlumno.UseVisualStyleBackColor = true;
            this.buttonGuardarAlumno.Click += new System.EventHandler(this.buttonGuardarAlumno_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AllowDrop = true;
            this.buttonCancelar.AutoEllipsis = true;
            this.buttonCancelar.Location = new System.Drawing.Point(111, 259);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 14;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // fmrNuevoEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 294);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardarAlumno);
            this.Controls.Add(this.comboBoxCarrera);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxDUI);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "fmrNuevoEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INGRESAR NUEVO ESTUDIANTE";
            this.Load += new System.EventHandler(this.fmrNuevoEstudiante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxDUI;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.ComboBox comboBoxCarrera;
        private System.Windows.Forms.Button buttonGuardarAlumno;
        private System.Windows.Forms.Button buttonCancelar;
    }
}