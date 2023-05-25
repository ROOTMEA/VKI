namespace BKİ
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boy = new System.Windows.Forms.TextBox();
            this.kilo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.sonuc = new System.Windows.Forms.Label();
            this.svki = new System.Windows.Forms.Label();
            this.vki = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(139, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vücut Kitle İndeksi Hesaplama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(140, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "BOY:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(141, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "KİLO:";
            // 
            // boy
            // 
            this.boy.Location = new System.Drawing.Point(222, 132);
            this.boy.Name = "boy";
            this.boy.Size = new System.Drawing.Size(108, 22);
            this.boy.TabIndex = 3;
            this.boy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boy_KeyPress);
            // 
            // kilo
            // 
            this.kilo.Location = new System.Drawing.Point(222, 190);
            this.kilo.Name = "kilo";
            this.kilo.Size = new System.Drawing.Size(108, 22);
            this.kilo.TabIndex = 4;
            this.kilo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kilo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(344, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "örn:1,80";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(344, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "örn:56,7";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(222, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(141, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "SONUÇ:";
            // 
            // sonuc
            // 
            this.sonuc.AutoSize = true;
            this.sonuc.Location = new System.Drawing.Point(227, 335);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(0, 16);
            this.sonuc.TabIndex = 9;
            // 
            // svki
            // 
            this.svki.AutoSize = true;
            this.svki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.svki.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.svki.Location = new System.Drawing.Point(141, 369);
            this.svki.Name = "svki";
            this.svki.Size = new System.Drawing.Size(44, 20);
            this.svki.TabIndex = 10;
            this.svki.Text = "VKİ:";
            // 
            // vki
            // 
            this.vki.AutoSize = true;
            this.vki.Location = new System.Drawing.Point(222, 369);
            this.vki.Name = "vki";
            this.vki.Size = new System.Drawing.Size(0, 16);
            this.vki.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.vki);
            this.Controls.Add(this.svki);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kilo);
            this.Controls.Add(this.boy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "VKİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boy;
        private System.Windows.Forms.TextBox kilo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label sonuc;
        private System.Windows.Forms.Label svki;
        private System.Windows.Forms.Label vki;
    }
}

