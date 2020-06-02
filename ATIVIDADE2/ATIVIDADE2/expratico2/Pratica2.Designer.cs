namespace expratico2
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
            this.msktxtbaltura = new System.Windows.Forms.MaskedTextBox();
            this.msktxtbpesoatual = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnmasculino = new System.Windows.Forms.RadioButton();
            this.rdbtnfeminino = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.msktxtpesoideal = new System.Windows.Forms.MaskedTextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altura";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso Atual";
            // 
            // msktxtbaltura
            // 
            this.msktxtbaltura.Location = new System.Drawing.Point(208, 99);
            this.msktxtbaltura.Mask = "0.00";
            this.msktxtbaltura.Name = "msktxtbaltura";
            this.msktxtbaltura.Size = new System.Drawing.Size(100, 22);
            this.msktxtbaltura.TabIndex = 2;
            // 
            // msktxtbpesoatual
            // 
            this.msktxtbpesoatual.Location = new System.Drawing.Point(208, 173);
            this.msktxtbpesoatual.Mask = "999.99";
            this.msktxtbpesoatual.Name = "msktxtbpesoatual";
            this.msktxtbpesoatual.Size = new System.Drawing.Size(100, 22);
            this.msktxtbpesoatual.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnmasculino);
            this.groupBox1.Controls.Add(this.rdbtnfeminino);
            this.groupBox1.Location = new System.Drawing.Point(499, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 127);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gênero";
            // 
            // rdbtnmasculino
            // 
            this.rdbtnmasculino.AutoSize = true;
            this.rdbtnmasculino.Location = new System.Drawing.Point(30, 82);
            this.rdbtnmasculino.Name = "rdbtnmasculino";
            this.rdbtnmasculino.Size = new System.Drawing.Size(92, 21);
            this.rdbtnmasculino.TabIndex = 1;
            this.rdbtnmasculino.Text = "masculino";
            this.rdbtnmasculino.UseVisualStyleBackColor = true;
            // 
            // rdbtnfeminino
            // 
            this.rdbtnfeminino.AutoSize = true;
            this.rdbtnfeminino.Checked = true;
            this.rdbtnfeminino.Location = new System.Drawing.Point(30, 40);
            this.rdbtnfeminino.Name = "rdbtnfeminino";
            this.rdbtnfeminino.Size = new System.Drawing.Size(86, 21);
            this.rdbtnfeminino.TabIndex = 0;
            this.rdbtnfeminino.TabStop = true;
            this.rdbtnfeminino.Text = "Feminino";
            this.rdbtnfeminino.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Peso Ideal";
            // 
            // msktxtpesoideal
            // 
            this.msktxtpesoideal.Location = new System.Drawing.Point(208, 255);
            this.msktxtpesoideal.Mask = "00.00kg";
            this.msktxtpesoideal.Name = "msktxtpesoideal";
            this.msktxtpesoideal.Size = new System.Drawing.Size(100, 22);
            this.msktxtpesoideal.TabIndex = 6;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(199, 347);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(109, 49);
            this.btncalcular.TabIndex = 7;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(388, 347);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(109, 49);
            this.btnfechar.TabIndex = 8;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.msktxtpesoideal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.msktxtbpesoatual);
            this.Controls.Add(this.msktxtbaltura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pratica2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox msktxtbaltura;
        private System.Windows.Forms.MaskedTextBox msktxtbpesoatual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtnmasculino;
        private System.Windows.Forms.RadioButton rdbtnfeminino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msktxtpesoideal;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnfechar;
    }
}

