namespace SinemaOtomasyonu
{
    partial class FormGunlukAnaliz
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
            this.lblBay = new System.Windows.Forms.Label();
            this.lblBayan = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBay
            // 
            this.lblBay.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblBay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBay.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.lblBay.Location = new System.Drawing.Point(28, 84);
            this.lblBay.Name = "lblBay";
            this.lblBay.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblBay.Size = new System.Drawing.Size(294, 69);
            this.lblBay.TabIndex = 7;
            this.lblBay.Text = "BAY SAYISI:";
            this.lblBay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBayan
            // 
            this.lblBayan.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblBayan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBayan.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.lblBayan.Location = new System.Drawing.Point(28, 165);
            this.lblBayan.Name = "lblBayan";
            this.lblBayan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblBayan.Size = new System.Drawing.Size(294, 69);
            this.lblBayan.TabIndex = 7;
            this.lblBayan.Text = "BAYAN SAYISI:";
            this.lblBayan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblToplam
            // 
            this.lblToplam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblToplam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblToplam.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.lblToplam.Location = new System.Drawing.Point(28, 244);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblToplam.Size = new System.Drawing.Size(294, 69);
            this.lblToplam.TabIndex = 7;
            this.lblToplam.Text = "IZLEYICI SAYISI:";
            this.lblToplam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 69);
            this.label4.TabIndex = 7;
            this.label4.Text = "GÜNLÜK ANALİZ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormGunlukAnaliz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 332);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lblBayan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBay);
            this.Name = "FormGunlukAnaliz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Günlük Analiz";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblBay;
        private System.Windows.Forms.Label lblBayan;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label label4;
    }
}