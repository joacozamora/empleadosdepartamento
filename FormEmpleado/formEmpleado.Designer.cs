﻿namespace FormEmpleado
{
    partial class formEmpleado
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label3 = new System.Windows.Forms.Label();
			this.FechaNacEmpleado = new System.Windows.Forms.DateTimePicker();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.btnModEmp = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.comDep = new System.Windows.Forms.ComboBox();
			this.txtCor = new System.Windows.Forms.TextBox();
			this.txtDni = new System.Windows.Forms.TextBox();
			this.txt2ap = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtAp = new System.Windows.Forms.TextBox();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.btn_BorrarDepa = new System.Windows.Forms.Button();
			this.btnModDep = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombreDepartamento = new System.Windows.Forms.TextBox();
			this.dgvDepa = new System.Windows.Forms.DataGridView();
			this.dgvEmpleado = new System.Windows.Forms.DataGridView();
			this.tabControl1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDepa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new System.Drawing.Point(75, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(573, 268);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.FechaNacEmpleado);
			this.tabPage2.Controls.Add(this.btnCancelar);
			this.tabPage2.Controls.Add(this.btnBorrar);
			this.tabPage2.Controls.Add(this.btnModEmp);
			this.tabPage2.Controls.Add(this.btnAgregar);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.label11);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.comDep);
			this.tabPage2.Controls.Add(this.txtCor);
			this.tabPage2.Controls.Add(this.txtDni);
			this.tabPage2.Controls.Add(this.txt2ap);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.txtAp);
			this.tabPage2.Controls.Add(this.txtNom);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(565, 242);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Empleado";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(413, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 13);
			this.label3.TabIndex = 94;
			this.label3.Text = "Fecha Nacimiento";
			// 
			// FechaNacEmpleado
			// 
			this.FechaNacEmpleado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.FechaNacEmpleado.Location = new System.Drawing.Point(416, 88);
			this.FechaNacEmpleado.Name = "FechaNacEmpleado";
			this.FechaNacEmpleado.Size = new System.Drawing.Size(100, 20);
			this.FechaNacEmpleado.TabIndex = 93;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(439, 192);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(102, 23);
			this.btnCancelar.TabIndex = 91;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// btnBorrar
			// 
			this.btnBorrar.Location = new System.Drawing.Point(289, 192);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(102, 23);
			this.btnBorrar.TabIndex = 90;
			this.btnBorrar.Text = "Borrar";
			this.btnBorrar.UseVisualStyleBackColor = true;
			this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
			// 
			// btnModEmp
			// 
			this.btnModEmp.Location = new System.Drawing.Point(148, 192);
			this.btnModEmp.Name = "btnModEmp";
			this.btnModEmp.Size = new System.Drawing.Size(102, 23);
			this.btnModEmp.TabIndex = 89;
			this.btnModEmp.Text = "Modificar";
			this.btnModEmp.UseVisualStyleBackColor = true;
			this.btnModEmp.Click += new System.EventHandler(this.btnModEmp_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(18, 192);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(90, 23);
			this.btnAgregar.TabIndex = 88;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(240, 64);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(26, 13);
			this.label9.TabIndex = 87;
			this.label9.Text = "DNI";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(240, 120);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(79, 13);
			this.label10.TabIndex = 86;
			this.label10.Text = "Departamentos";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(15, 120);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(32, 13);
			this.label11.TabIndex = 85;
			this.label11.Text = "Email";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(15, 64);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(90, 13);
			this.label12.TabIndex = 84;
			this.label12.Text = "Segundo Apellido";
			// 
			// comDep
			// 
			this.comDep.FormattingEnabled = true;
			this.comDep.Location = new System.Drawing.Point(242, 136);
			this.comDep.Name = "comDep";
			this.comDep.Size = new System.Drawing.Size(195, 21);
			this.comDep.TabIndex = 83;
			// 
			// txtCor
			// 
			this.txtCor.Location = new System.Drawing.Point(14, 136);
			this.txtCor.Name = "txtCor";
			this.txtCor.Size = new System.Drawing.Size(195, 20);
			this.txtCor.TabIndex = 82;
			// 
			// txtDni
			// 
			this.txtDni.Location = new System.Drawing.Point(243, 88);
			this.txtDni.Name = "txtDni";
			this.txtDni.Size = new System.Drawing.Size(85, 20);
			this.txtDni.TabIndex = 81;
			// 
			// txt2ap
			// 
			this.txt2ap.Location = new System.Drawing.Point(18, 88);
			this.txt2ap.Name = "txt2ap";
			this.txt2ap.Size = new System.Drawing.Size(149, 20);
			this.txt2ap.TabIndex = 80;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(15, 13);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 13);
			this.label7.TabIndex = 79;
			this.label7.Text = "Nombre";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(239, 13);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(76, 13);
			this.label8.TabIndex = 78;
			this.label8.Text = "Primer Apellido";
			// 
			// txtAp
			// 
			this.txtAp.Location = new System.Drawing.Point(243, 29);
			this.txtAp.Name = "txtAp";
			this.txtAp.Size = new System.Drawing.Size(194, 20);
			this.txtAp.TabIndex = 77;
			// 
			// txtNom
			// 
			this.txtNom.Location = new System.Drawing.Point(18, 29);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(149, 20);
			this.txtNom.TabIndex = 76;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(565, 242);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Dep/Emp";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.btn_BorrarDepa);
			this.tabPage1.Controls.Add(this.btnModDep);
			this.tabPage1.Controls.Add(this.button4);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.txtNombreDepartamento);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(565, 242);
			this.tabPage1.TabIndex = 3;
			this.tabPage1.Text = "Departamento";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(410, 109);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 42;
			this.button1.Text = "Cancelar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btn_BorrarDepa
			// 
			this.btn_BorrarDepa.Location = new System.Drawing.Point(300, 109);
			this.btn_BorrarDepa.Name = "btn_BorrarDepa";
			this.btn_BorrarDepa.Size = new System.Drawing.Size(75, 23);
			this.btn_BorrarDepa.TabIndex = 41;
			this.btn_BorrarDepa.Text = "Borrar";
			this.btn_BorrarDepa.UseVisualStyleBackColor = true;
			this.btn_BorrarDepa.Click += new System.EventHandler(this.btn_BorrarDepa_Click);
			// 
			// btnModDep
			// 
			this.btnModDep.Location = new System.Drawing.Point(202, 109);
			this.btnModDep.Name = "btnModDep";
			this.btnModDep.Size = new System.Drawing.Size(75, 23);
			this.btnModDep.TabIndex = 40;
			this.btnModDep.Text = "Modificar";
			this.btnModDep.UseVisualStyleBackColor = true;
			this.btnModDep.Click += new System.EventHandler(this.btnModDep_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(106, 109);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 39;
			this.button4.Text = "Agregar";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(103, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 13);
			this.label2.TabIndex = 38;
			this.label2.Text = "Nombre Departamneto:";
			// 
			// txtNombreDepartamento
			// 
			this.txtNombreDepartamento.Location = new System.Drawing.Point(106, 62);
			this.txtNombreDepartamento.Name = "txtNombreDepartamento";
			this.txtNombreDepartamento.Size = new System.Drawing.Size(227, 20);
			this.txtNombreDepartamento.TabIndex = 36;
			// 
			// dgvDepa
			// 
			this.dgvDepa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDepa.Location = new System.Drawing.Point(75, 422);
			this.dgvDepa.Name = "dgvDepa";
			this.dgvDepa.Size = new System.Drawing.Size(689, 110);
			this.dgvDepa.TabIndex = 92;
			// 
			// dgvEmpleado
			// 
			this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEmpleado.Location = new System.Drawing.Point(75, 296);
			this.dgvEmpleado.Name = "dgvEmpleado";
			this.dgvEmpleado.Size = new System.Drawing.Size(1082, 110);
			this.dgvEmpleado.TabIndex = 93;
			// 
			// formEmpleado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1387, 555);
			this.Controls.Add(this.dgvEmpleado);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.dgvDepa);
			this.Name = "formEmpleado";
			this.Text = "formEmpleado";
			this.tabControl1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDepa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FechaNacEmpleado;
        private System.Windows.Forms.DataGridView dgvDepa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModEmp;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comDep;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txt2ap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAp;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_BorrarDepa;
        private System.Windows.Forms.Button btnModDep;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreDepartamento;
        private System.Windows.Forms.DataGridView dgvEmpleado;
    }
}