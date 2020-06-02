namespace ATIVIDADE4
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
            this.lbdDados = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.msktxtbnome = new System.Windows.Forms.MaskedTextBox();
            this.msktxtbsalariobruto = new System.Windows.Forms.MaskedTextBox();
            this.msktxtbfilhos = new System.Windows.Forms.MaskedTextBox();
            this.msktxtbaliquotaINSS = new System.Windows.Forms.MaskedTextBox();
            this.msktxtbaliquotaIRPF = new System.Windows.Forms.MaskedTextBox();
            this.msktxtbsalariofamilia = new System.Windows.Forms.MaskedTextBox();
            this.msktxtbsalarioliquido = new System.Windows.Forms.MaskedTextBox();
            this.msktxtbdescontoINSS = new System.Windows.Forms.MaskedTextBox();
            this.msktxtbdescontoIRPF = new System.Windows.Forms.MaskedTextBox();
            this.ckbCasado = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnHomem = new System.Windows.Forms.RadioButton();
            this.rdbtnMulher = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome funcionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salario bruto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de filhos";
            // 
            // lbdDados
            // 
            this.lbdDados.AutoSize = true;
            this.lbdDados.Location = new System.Drawing.Point(12, 149);
            this.lbdDados.Name = "lbdDados";
            this.lbdDados.Size = new System.Drawing.Size(63, 17);
            this.lbdDados.TabIndex = 3;
            this.lbdDados.Text = "lblDados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Aliquota INSS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Aliquota IRPF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Salario Família";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Salario Líquido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Desconto INSS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(301, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Desconto IRPF";
            // 
            // msktxtbnome
            // 
            this.msktxtbnome.Location = new System.Drawing.Point(191, 34);
            this.msktxtbnome.Name = "msktxtbnome";
            this.msktxtbnome.Size = new System.Drawing.Size(100, 22);
            this.msktxtbnome.TabIndex = 11;
            // 
            // msktxtbsalariobruto
            // 
            this.msktxtbsalariobruto.Location = new System.Drawing.Point(191, 71);
            this.msktxtbsalariobruto.Mask = "99990.00";
            this.msktxtbsalariobruto.Name = "msktxtbsalariobruto";
            this.msktxtbsalariobruto.Size = new System.Drawing.Size(100, 22);
            this.msktxtbsalariobruto.TabIndex = 12;
            // 
            // msktxtbfilhos
            // 
            this.msktxtbfilhos.Location = new System.Drawing.Point(191, 114);
            this.msktxtbfilhos.Mask = "99";
            this.msktxtbfilhos.Name = "msktxtbfilhos";
            this.msktxtbfilhos.Size = new System.Drawing.Size(100, 22);
            this.msktxtbfilhos.TabIndex = 13;
            // 
            // msktxtbaliquotaINSS
            // 
            this.msktxtbaliquotaINSS.Enabled = false;
            this.msktxtbaliquotaINSS.Location = new System.Drawing.Point(171, 199);
            this.msktxtbaliquotaINSS.Name = "msktxtbaliquotaINSS";
            this.msktxtbaliquotaINSS.Size = new System.Drawing.Size(100, 22);
            this.msktxtbaliquotaINSS.TabIndex = 14;
            // 
            // msktxtbaliquotaIRPF
            // 
            this.msktxtbaliquotaIRPF.Enabled = false;
            this.msktxtbaliquotaIRPF.Location = new System.Drawing.Point(171, 250);
            this.msktxtbaliquotaIRPF.Name = "msktxtbaliquotaIRPF";
            this.msktxtbaliquotaIRPF.Size = new System.Drawing.Size(100, 22);
            this.msktxtbaliquotaIRPF.TabIndex = 15;
            // 
            // msktxtbsalariofamilia
            // 
            this.msktxtbsalariofamilia.Enabled = false;
            this.msktxtbsalariofamilia.Location = new System.Drawing.Point(171, 295);
            this.msktxtbsalariofamilia.Name = "msktxtbsalariofamilia";
            this.msktxtbsalariofamilia.Size = new System.Drawing.Size(100, 22);
            this.msktxtbsalariofamilia.TabIndex = 16;
            // 
            // msktxtbsalarioliquido
            // 
            this.msktxtbsalarioliquido.Enabled = false;
            this.msktxtbsalarioliquido.Location = new System.Drawing.Point(171, 336);
            this.msktxtbsalarioliquido.Name = "msktxtbsalarioliquido";
            this.msktxtbsalarioliquido.Size = new System.Drawing.Size(100, 22);
            this.msktxtbsalarioliquido.TabIndex = 17;
            // 
            // msktxtbdescontoINSS
            // 
            this.msktxtbdescontoINSS.Enabled = false;
            this.msktxtbdescontoINSS.Location = new System.Drawing.Point(427, 199);
            this.msktxtbdescontoINSS.Name = "msktxtbdescontoINSS";
            this.msktxtbdescontoINSS.Size = new System.Drawing.Size(100, 22);
            this.msktxtbdescontoINSS.TabIndex = 18;
            // 
            // msktxtbdescontoIRPF
            // 
            this.msktxtbdescontoIRPF.Enabled = false;
            this.msktxtbdescontoIRPF.Location = new System.Drawing.Point(427, 250);
            this.msktxtbdescontoIRPF.Name = "msktxtbdescontoIRPF";
            this.msktxtbdescontoIRPF.Size = new System.Drawing.Size(100, 22);
            this.msktxtbdescontoIRPF.TabIndex = 19;
            // 
            // ckbCasado
            // 
            this.ckbCasado.AutoSize = true;
            this.ckbCasado.Location = new System.Drawing.Point(515, 149);
            this.ckbCasado.Name = "ckbCasado";
            this.ckbCasado.Size = new System.Drawing.Size(78, 21);
            this.ckbCasado.TabIndex = 20;
            this.ckbCasado.Text = "Casado";
            this.ckbCasado.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnHomem);
            this.groupBox1.Controls.Add(this.rdbtnMulher);
            this.groupBox1.Location = new System.Drawing.Point(548, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rdbtnHomem
            // 
            this.rdbtnHomem.AutoSize = true;
            this.rdbtnHomem.Location = new System.Drawing.Point(25, 60);
            this.rdbtnHomem.Name = "rdbtnHomem";
            this.rdbtnHomem.Size = new System.Drawing.Size(77, 21);
            this.rdbtnHomem.TabIndex = 1;
            this.rdbtnHomem.Text = "Homem";
            this.rdbtnHomem.UseVisualStyleBackColor = true;
            // 
            // rdbtnMulher
            // 
            this.rdbtnMulher.AutoSize = true;
            this.rdbtnMulher.Checked = true;
            this.rdbtnMulher.Location = new System.Drawing.Point(25, 33);
            this.rdbtnMulher.Name = "rdbtnMulher";
            this.rdbtnMulher.Size = new System.Drawing.Size(72, 21);
            this.rdbtnMulher.TabIndex = 0;
            this.rdbtnMulher.TabStop = true;
            this.rdbtnMulher.Text = "Mulher";
            this.rdbtnMulher.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 44);
            this.button1.TabIndex = 22;
            this.button1.Text = "Verificar desconto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 44);
            this.button2.TabIndex = 23;
            this.button2.Text = "fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ckbCasado);
            this.Controls.Add(this.msktxtbdescontoIRPF);
            this.Controls.Add(this.msktxtbdescontoINSS);
            this.Controls.Add(this.msktxtbsalarioliquido);
            this.Controls.Add(this.msktxtbsalariofamilia);
            this.Controls.Add(this.msktxtbaliquotaIRPF);
            this.Controls.Add(this.msktxtbaliquotaINSS);
            this.Controls.Add(this.msktxtbfilhos);
            this.Controls.Add(this.msktxtbsalariobruto);
            this.Controls.Add(this.msktxtbnome);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbdDados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Casado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbdDados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox msktxtbnome;
        private System.Windows.Forms.MaskedTextBox msktxtbsalariobruto;
        private System.Windows.Forms.MaskedTextBox msktxtbfilhos;
        private System.Windows.Forms.MaskedTextBox msktxtbaliquotaINSS;
        private System.Windows.Forms.MaskedTextBox msktxtbaliquotaIRPF;
        private System.Windows.Forms.MaskedTextBox msktxtbsalariofamilia;
        private System.Windows.Forms.MaskedTextBox msktxtbsalarioliquido;
        private System.Windows.Forms.MaskedTextBox msktxtbdescontoINSS;
        private System.Windows.Forms.MaskedTextBox msktxtbdescontoIRPF;
        private System.Windows.Forms.CheckBox ckbCasado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtnHomem;
        private System.Windows.Forms.RadioButton rdbtnMulher;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

