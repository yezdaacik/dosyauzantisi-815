namespace Dosya_uzantısı_ve_tür_değişme_815
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbVideo = new System.Windows.Forms.RadioButton();
            this.rbResim = new System.Windows.Forms.RadioButton();
            this.lbTur = new System.Windows.Forms.ListBox();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTur);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uzanlı Türü";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbVideo);
            this.groupBox2.Controls.Add(this.rbResim);
            this.groupBox2.Location = new System.Drawing.Point(246, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dosya Türü";
            // 
            // rbVideo
            // 
            this.rbVideo.AutoSize = true;
            this.rbVideo.Location = new System.Drawing.Point(6, 39);
            this.rbVideo.Name = "rbVideo";
            this.rbVideo.Size = new System.Drawing.Size(92, 17);
            this.rbVideo.TabIndex = 0;
            this.rbVideo.TabStop = true;
            this.rbVideo.Text = "Video Dosyası";
            this.rbVideo.UseVisualStyleBackColor = true;
            // 
            // rbResim
            // 
            this.rbResim.AutoSize = true;
            this.rbResim.Location = new System.Drawing.Point(6, 73);
            this.rbResim.Name = "rbResim";
            this.rbResim.Size = new System.Drawing.Size(94, 17);
            this.rbResim.TabIndex = 1;
            this.rbResim.TabStop = true;
            this.rbResim.Text = "Resim Dosyası";
            this.rbResim.UseVisualStyleBackColor = true;
            // 
            // lbTur
            // 
            this.lbTur.FormattingEnabled = true;
            this.lbTur.Items.AddRange(new object[] {
            "MP4",
            "JPG",
            "MOV",
            "PNG"});
            this.lbTur.Location = new System.Drawing.Point(6, 17);
            this.lbTur.Name = "lbTur";
            this.lbTur.Size = new System.Drawing.Size(120, 95);
            this.lbTur.TabIndex = 2;
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(181, 180);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(87, 38);
            this.btnKontrol.TabIndex = 3;
            this.btnKontrol.Text = "Kontrol Et";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 246);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbTur;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbVideo;
        private System.Windows.Forms.RadioButton rbResim;
        private System.Windows.Forms.Button btnKontrol;
    }
}

