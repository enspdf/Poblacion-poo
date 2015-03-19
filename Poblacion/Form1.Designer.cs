namespace Poblacion
{
    partial class Form1
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
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.txtSalario_promedio = new System.Windows.Forms.TextBox();
            this.txtN_habitantes = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtIngresos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pais:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ciudad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salario promedio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nº habitantes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ingresos:";
            // 
            // cbPais
            // 
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(135, 14);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(222, 21);
            this.cbPais.TabIndex = 6;
            this.cbPais.SelectedIndexChanged += new System.EventHandler(this.cbPais_SelectedIndexChanged);
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(135, 46);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(222, 21);
            this.cbDepartamento.TabIndex = 7;
            this.cbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cbDepartamento_SelectedIndexChanged);
            // 
            // cbCiudad
            // 
            this.cbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(135, 77);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(222, 21);
            this.cbCiudad.TabIndex = 8;
            this.cbCiudad.SelectedIndexChanged += new System.EventHandler(this.cbCiudad_SelectedIndexChanged);
            // 
            // txtSalario_promedio
            // 
            this.txtSalario_promedio.Enabled = false;
            this.txtSalario_promedio.Location = new System.Drawing.Point(135, 111);
            this.txtSalario_promedio.Name = "txtSalario_promedio";
            this.txtSalario_promedio.Size = new System.Drawing.Size(222, 20);
            this.txtSalario_promedio.TabIndex = 9;
            // 
            // txtN_habitantes
            // 
            this.txtN_habitantes.Location = new System.Drawing.Point(135, 141);
            this.txtN_habitantes.Name = "txtN_habitantes";
            this.txtN_habitantes.Size = new System.Drawing.Size(142, 20);
            this.txtN_habitantes.TabIndex = 10;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(282, 139);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtIngresos
            // 
            this.txtIngresos.Enabled = false;
            this.txtIngresos.Location = new System.Drawing.Point(135, 172);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.Size = new System.Drawing.Size(222, 20);
            this.txtIngresos.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 206);
            this.Controls.Add(this.txtIngresos);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtN_habitantes);
            this.Controls.Add(this.txtSalario_promedio);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.cbDepartamento);
            this.Controls.Add(this.cbPais);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ingresos Ciudades";
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
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.TextBox txtSalario_promedio;
        private System.Windows.Forms.TextBox txtN_habitantes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtIngresos;
    }
}

