namespace SinemaOtomasyonu
{
    partial class FormRezarvasyon
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
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.maskedTC = new System.Windows.Forms.MaskedTextBox();
            this.radioBay = new System.Windows.Forms.RadioButton();
            this.radioBayan = new System.Windows.Forms.RadioButton();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 101);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rezervasyon Ekranı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "TC";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(110, 134);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(198, 20);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // maskedTC
            // 
            this.maskedTC.Location = new System.Drawing.Point(110, 166);
            this.maskedTC.Mask = "00000000000";
            this.maskedTC.Name = "maskedTC";
            this.maskedTC.Size = new System.Drawing.Size(198, 20);
            this.maskedTC.TabIndex = 3;
            this.maskedTC.ValidatingType = typeof(int);
            // 
            // radioBay
            // 
            this.radioBay.AutoSize = true;
            this.radioBay.Checked = true;
            this.radioBay.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.radioBay.Location = new System.Drawing.Point(315, 132);
            this.radioBay.Name = "radioBay";
            this.radioBay.Size = new System.Drawing.Size(60, 24);
            this.radioBay.TabIndex = 4;
            this.radioBay.TabStop = true;
            this.radioBay.Text = "Bay";
            this.radioBay.UseVisualStyleBackColor = true;
            // 
            // radioBayan
            // 
            this.radioBayan.AutoSize = true;
            this.radioBayan.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.radioBayan.Location = new System.Drawing.Point(314, 164);
            this.radioBayan.Name = "radioBayan";
            this.radioBayan.Size = new System.Drawing.Size(81, 24);
            this.radioBayan.TabIndex = 4;
            this.radioBayan.Text = "Bayan";
            this.radioBayan.UseVisualStyleBackColor = true;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.btnIptal.Location = new System.Drawing.Point(196, 211);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(96, 60);
            this.btnIptal.TabIndex = 5;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.PaleGreen;
            this.btnOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnayla.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.btnOnayla.Location = new System.Drawing.Point(299, 211);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(96, 60);
            this.btnOnayla.TabIndex = 5;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // FormRezarvasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 286);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.radioBayan);
            this.Controls.Add(this.radioBay);
            this.Controls.Add(this.maskedTC);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRezarvasyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezarvasyon Formu";
            this.Load += new System.EventHandler(this.FormRezarvasyon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.MaskedTextBox maskedTC;
        private System.Windows.Forms.RadioButton radioBay;
        private System.Windows.Forms.RadioButton radioBayan;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnOnayla;
    }
}