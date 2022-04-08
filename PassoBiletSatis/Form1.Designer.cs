
namespace PassoBiletSatis
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txbEtkinlikLink = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbButonXPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbOlumsuzMesaj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbKacSaniyedeBir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(462, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etkinlik Linki";
            // 
            // txbEtkinlikLink
            // 
            this.txbEtkinlikLink.Location = new System.Drawing.Point(616, 46);
            this.txbEtkinlikLink.Name = "txbEtkinlikLink";
            this.txbEtkinlikLink.Size = new System.Drawing.Size(856, 39);
            this.txbEtkinlikLink.TabIndex = 1;
            this.txbEtkinlikLink.Text = "https://www.passo.com.tr/tr/etkinlik/fenerbahce-galatasaray-super-lig/3097324";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1432, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Taramaya Başla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbButonXPath
            // 
            this.txbButonXPath.Location = new System.Drawing.Point(616, 107);
            this.txbButonXPath.Name = "txbButonXPath";
            this.txbButonXPath.Size = new System.Drawing.Size(856, 39);
            this.txbButonXPath.TabIndex = 4;
            this.txbButonXPath.Text = "/html/body/app-root/app-layout/app-event/section[1]/div/div[2]/div/div[1]/div[2]/" +
    "div[4]/button";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(454, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buton XPath";
            // 
            // txbOlumsuzMesaj
            // 
            this.txbOlumsuzMesaj.Location = new System.Drawing.Point(616, 168);
            this.txbOlumsuzMesaj.Name = "txbOlumsuzMesaj";
            this.txbOlumsuzMesaj.Size = new System.Drawing.Size(856, 39);
            this.txbOlumsuzMesaj.TabIndex = 6;
            this.txbOlumsuzMesaj.Text = "Daha Sonra Tekrar Deneyiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(298, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Butondaki olumsuz mesaj";
            // 
            // txbKacSaniyedeBir
            // 
            this.txbKacSaniyedeBir.Location = new System.Drawing.Point(616, 229);
            this.txbKacSaniyedeBir.Name = "txbKacSaniyedeBir";
            this.txbKacSaniyedeBir.Size = new System.Drawing.Size(856, 39);
            this.txbKacSaniyedeBir.TabIndex = 8;
            this.txbKacSaniyedeBir.Text = "30";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(160, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(450, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sayfa Kaç Saniyede Bir Kontrol Edilsin";
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 32;
            this.listBoxLog.Location = new System.Drawing.Point(40, 350);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(1432, 452);
            this.listBoxLog.TabIndex = 9;
            this.listBoxLog.SelectedIndexChanged += new System.EventHandler(this.listBoxLog_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(40, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 170);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1517, 843);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.txbKacSaniyedeBir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbOlumsuzMesaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbButonXPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbEtkinlikLink);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbEtkinlikLink;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbButonXPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbOlumsuzMesaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbKacSaniyedeBir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Timer timer1;
    }
}

