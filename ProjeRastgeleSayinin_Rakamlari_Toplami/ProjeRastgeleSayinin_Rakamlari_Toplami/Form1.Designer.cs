namespace ProjeRastgeleSayinin_Rakamlari_Toplami
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
            this.btnRastgeleSayiOlustur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRastgeleSayiOlustur
            // 
            this.btnRastgeleSayiOlustur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRastgeleSayiOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRastgeleSayiOlustur.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.btnRastgeleSayiOlustur.Location = new System.Drawing.Point(11, 12);
            this.btnRastgeleSayiOlustur.Name = "btnRastgeleSayiOlustur";
            this.btnRastgeleSayiOlustur.Size = new System.Drawing.Size(425, 66);
            this.btnRastgeleSayiOlustur.TabIndex = 0;
            this.btnRastgeleSayiOlustur.Text = "Rasgele Sayi Oluştur";
            this.btnRastgeleSayiOlustur.UseVisualStyleBackColor = false;
            this.btnRastgeleSayiOlustur.Click += new System.EventHandler(this.btnRastgeleSayiOlustur_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 73);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 163);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRastgeleSayiOlustur);
            this.Name = "Form1";
            this.Text = "Rastgele Oluşturulan Sayının Rakamları Toplamı Programı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRastgeleSayiOlustur;
        private System.Windows.Forms.Label label1;
    }
}

