namespace OdevPersonelGorev
{
    partial class FormNewTask
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
            this.txtGorevAdi = new System.Windows.Forms.TextBox();
            this.txtGorevAciklamasi = new System.Windows.Forms.TextBox();
            this.datePickerGorevTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblHataMesaji = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGorevAdi
            // 
            this.txtGorevAdi.Location = new System.Drawing.Point(118, 11);
            this.txtGorevAdi.Name = "txtGorevAdi";
            this.txtGorevAdi.Size = new System.Drawing.Size(253, 20);
            this.txtGorevAdi.TabIndex = 20;
            // 
            // txtGorevAciklamasi
            // 
            this.txtGorevAciklamasi.Location = new System.Drawing.Point(118, 39);
            this.txtGorevAciklamasi.Name = "txtGorevAciklamasi";
            this.txtGorevAciklamasi.Size = new System.Drawing.Size(253, 20);
            this.txtGorevAciklamasi.TabIndex = 21;
            // 
            // datePickerGorevTarihi
            // 
            this.datePickerGorevTarihi.Location = new System.Drawing.Point(118, 67);
            this.datePickerGorevTarihi.Name = "datePickerGorevTarihi";
            this.datePickerGorevTarihi.Size = new System.Drawing.Size(253, 20);
            this.datePickerGorevTarihi.TabIndex = 19;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Image = global::OdevPersonelGorev.Properties.Resources.save_32px;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(118, 95);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(253, 36);
            this.btnKaydet.TabIndex = 18;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblHataMesaji
            // 
            this.lblHataMesaji.AutoSize = true;
            this.lblHataMesaji.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHataMesaji.Location = new System.Drawing.Point(115, 198);
            this.lblHataMesaji.Name = "lblHataMesaji";
            this.lblHataMesaji.Size = new System.Drawing.Size(19, 13);
            this.lblHataMesaji.TabIndex = 13;
            this.lblHataMesaji.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Hata Mesajı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Görev Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Görev Açıklaması:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Görev Adi:";
            // 
            // FormNewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(382, 223);
            this.Controls.Add(this.txtGorevAdi);
            this.Controls.Add(this.txtGorevAciklamasi);
            this.Controls.Add(this.datePickerGorevTarihi);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblHataMesaji);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNewTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNewTask";
            this.Load += new System.EventHandler(this.FormNewTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGorevAdi;
        private System.Windows.Forms.TextBox txtGorevAciklamasi;
        private System.Windows.Forms.DateTimePicker datePickerGorevTarihi;
        public System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblHataMesaji;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}