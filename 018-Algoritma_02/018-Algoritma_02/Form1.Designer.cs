namespace _018_Algoritma_02
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTekSayilar = new System.Windows.Forms.Label();
            this.lblCiftSayilar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tek Sayılar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cift Sayılar";
            // 
            // lblTekSayilar
            // 
            this.lblTekSayilar.AutoSize = true;
            this.lblTekSayilar.Location = new System.Drawing.Point(54, 120);
            this.lblTekSayilar.Name = "lblTekSayilar";
            this.lblTekSayilar.Size = new System.Drawing.Size(19, 13);
            this.lblTekSayilar.TabIndex = 3;
            this.lblTekSayilar.Text = "00";
            // 
            // lblCiftSayilar
            // 
            this.lblCiftSayilar.AutoSize = true;
            this.lblCiftSayilar.Location = new System.Drawing.Point(289, 120);
            this.lblCiftSayilar.Name = "lblCiftSayilar";
            this.lblCiftSayilar.Size = new System.Drawing.Size(19, 13);
            this.lblCiftSayilar.TabIndex = 4;
            this.lblCiftSayilar.Text = "00";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 173);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCiftSayilar);
            this.Controls.Add(this.lblTekSayilar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTekSayilar;
        private System.Windows.Forms.Label lblCiftSayilar;
        private System.Windows.Forms.TextBox textBox1;
    }
}

