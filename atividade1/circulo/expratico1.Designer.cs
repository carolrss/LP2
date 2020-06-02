namespace circulo
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
            this.lblraio = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblvolume = new System.Windows.Forms.Label();
            this.txtbraio = new System.Windows.Forms.TextBox();
            this.txtbaltura = new System.Windows.Forms.TextBox();
            this.txtbvolume = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblraio
            // 
            this.lblraio.AutoSize = true;
            this.lblraio.Location = new System.Drawing.Point(97, 55);
            this.lblraio.Name = "lblraio";
            this.lblraio.Size = new System.Drawing.Size(37, 17);
            this.lblraio.TabIndex = 0;
            this.lblraio.Text = "Raio";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Location = new System.Drawing.Point(97, 154);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(45, 17);
            this.lblaltura.TabIndex = 1;
            this.lblaltura.Text = "Altura";
            // 
            // lblvolume
            // 
            this.lblvolume.AutoSize = true;
            this.lblvolume.Location = new System.Drawing.Point(97, 268);
            this.lblvolume.Name = "lblvolume";
            this.lblvolume.Size = new System.Drawing.Size(55, 17);
            this.lblvolume.TabIndex = 2;
            this.lblvolume.Text = "Volume";
            // 
            // txtbraio
            // 
            this.txtbraio.Location = new System.Drawing.Point(241, 55);
            this.txtbraio.Name = "txtbraio";
            this.txtbraio.Size = new System.Drawing.Size(100, 22);
            this.txtbraio.TabIndex = 3;
            // 
            // txtbaltura
            // 
            this.txtbaltura.Location = new System.Drawing.Point(241, 165);
            this.txtbaltura.Name = "txtbaltura";
            this.txtbaltura.Size = new System.Drawing.Size(100, 22);
            this.txtbaltura.TabIndex = 4;
            // 
            // txtbvolume
            // 
            this.txtbvolume.Location = new System.Drawing.Point(241, 265);
            this.txtbvolume.Name = "txtbvolume";
            this.txtbvolume.Size = new System.Drawing.Size(100, 22);
            this.txtbvolume.TabIndex = 5;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(190, 359);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(99, 37);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(410, 359);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(90, 37);
            this.btnfechar.TabIndex = 7;
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
            this.Controls.Add(this.txtbvolume);
            this.Controls.Add(this.txtbaltura);
            this.Controls.Add(this.txtbraio);
            this.Controls.Add(this.lblvolume);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblraio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblraio;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lblvolume;
        private System.Windows.Forms.TextBox txtbraio;
        private System.Windows.Forms.TextBox txtbaltura;
        private System.Windows.Forms.TextBox txtbvolume;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnfechar;
    }
}

