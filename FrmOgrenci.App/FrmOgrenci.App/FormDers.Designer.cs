namespace FrmOgrenci.App
{
    partial class FormDers
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
            this.txtKodu = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtViz = new System.Windows.Forms.TextBox();
            this.txtFnl = new System.Windows.Forms.TextBox();
            this.btnileri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vize Notu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Final Notu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ders Kodu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ders Adı:";
            // 
            // txtKodu
            // 
            this.txtKodu.Location = new System.Drawing.Point(302, 72);
            this.txtKodu.Name = "txtKodu";
            this.txtKodu.Size = new System.Drawing.Size(100, 22);
            this.txtKodu.TabIndex = 5;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(302, 119);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 22);
            this.txtAdi.TabIndex = 6;
            // 
            // txtViz
            // 
            this.txtViz.Location = new System.Drawing.Point(302, 177);
            this.txtViz.Name = "txtViz";
            this.txtViz.Size = new System.Drawing.Size(100, 22);
            this.txtViz.TabIndex = 7;
            // 
            // txtFnl
            // 
            this.txtFnl.Location = new System.Drawing.Point(302, 238);
            this.txtFnl.Name = "txtFnl";
            this.txtFnl.Size = new System.Drawing.Size(100, 22);
            this.txtFnl.TabIndex = 8;
            // 
            // btnileri
            // 
            this.btnileri.Location = new System.Drawing.Point(302, 322);
            this.btnileri.Name = "btnileri";
            this.btnileri.Size = new System.Drawing.Size(75, 23);
            this.btnileri.TabIndex = 9;
            this.btnileri.Text = "İleri";
            this.btnileri.UseVisualStyleBackColor = true;
            this.btnileri.Click += new System.EventHandler(this.btnileri_Click);
            // 
            // FormDers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnileri);
            this.Controls.Add(this.txtFnl);
            this.Controls.Add(this.txtViz);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.txtKodu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDers";
            this.Text = "FormDers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKodu;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtViz;
        private System.Windows.Forms.TextBox txtFnl;
        private System.Windows.Forms.Button btnileri;
    }
}