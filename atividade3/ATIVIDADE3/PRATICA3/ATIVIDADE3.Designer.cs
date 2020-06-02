namespace PRATICA3
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
            this.txtbladoB = new System.Windows.Forms.TextBox();
            this.txtbladoC = new System.Windows.Forms.TextBox();
            this.txtbladoA = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbladoB
            // 
            this.txtbladoB.Location = new System.Drawing.Point(167, 201);
            this.txtbladoB.Name = "txtbladoB";
            this.txtbladoB.Size = new System.Drawing.Size(100, 22);
            this.txtbladoB.TabIndex = 0;
            // 
            // txtbladoC
            // 
            this.txtbladoC.Location = new System.Drawing.Point(464, 201);
            this.txtbladoC.Name = "txtbladoC";
            this.txtbladoC.Size = new System.Drawing.Size(100, 22);
            this.txtbladoC.TabIndex = 1;
            // 
            // txtbladoA
            // 
            this.txtbladoA.Location = new System.Drawing.Point(322, 60);
            this.txtbladoA.Name = "txtbladoA";
            this.txtbladoA.Size = new System.Drawing.Size(100, 22);
            this.txtbladoA.TabIndex = 2;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(210, 328);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(106, 55);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "Calcular  triangulo";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 55);
            this.button2.TabIndex = 4;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "C:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtbladoA);
            this.Controls.Add(this.txtbladoC);
            this.Controls.Add(this.txtbladoB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbladoB;
        private System.Windows.Forms.TextBox txtbladoC;
        private System.Windows.Forms.TextBox txtbladoA;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

