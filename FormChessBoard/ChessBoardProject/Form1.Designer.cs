namespace ChessBoardProject
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBoyamaPortakal = new System.Windows.Forms.Button();
            this.buttonBoyamaSiyah = new System.Windows.Forms.Button();
            this.buttonBoyamaSari = new System.Windows.Forms.Button();
            this.buttonBoyamaKirmizi = new System.Windows.Forms.Button();
            this.buttonBoyamaYesil = new System.Windows.Forms.Button();
            this.buttonBoyamaMavi = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1092, 60);
            this.label1.TabIndex = 14;
            this.label1.Text = "SATRANÇ TAHTASI BOYUYORUM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(241, 73);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // buttonBoyamaPortakal
            // 
            this.buttonBoyamaPortakal.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonBoyamaPortakal.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBoyamaPortakal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBoyamaPortakal.Location = new System.Drawing.Point(19, 372);
            this.buttonBoyamaPortakal.Name = "buttonBoyamaPortakal";
            this.buttonBoyamaPortakal.Size = new System.Drawing.Size(200, 97);
            this.buttonBoyamaPortakal.TabIndex = 10;
            this.buttonBoyamaPortakal.Text = "Tahtayı Boya";
            this.buttonBoyamaPortakal.UseVisualStyleBackColor = false;
            this.buttonBoyamaPortakal.Click += new System.EventHandler(this.ImageBoyama);
            // 
            // buttonBoyamaSiyah
            // 
            this.buttonBoyamaSiyah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBoyamaSiyah.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBoyamaSiyah.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBoyamaSiyah.Location = new System.Drawing.Point(19, 578);
            this.buttonBoyamaSiyah.Name = "buttonBoyamaSiyah";
            this.buttonBoyamaSiyah.Size = new System.Drawing.Size(200, 97);
            this.buttonBoyamaSiyah.TabIndex = 13;
            this.buttonBoyamaSiyah.Text = "Tahtayı Boya";
            this.buttonBoyamaSiyah.UseVisualStyleBackColor = false;
            this.buttonBoyamaSiyah.Click += new System.EventHandler(this.ImageBoyama);
            // 
            // buttonBoyamaSari
            // 
            this.buttonBoyamaSari.BackColor = System.Drawing.Color.Gold;
            this.buttonBoyamaSari.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBoyamaSari.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBoyamaSari.Location = new System.Drawing.Point(19, 475);
            this.buttonBoyamaSari.Name = "buttonBoyamaSari";
            this.buttonBoyamaSari.Size = new System.Drawing.Size(200, 97);
            this.buttonBoyamaSari.TabIndex = 12;
            this.buttonBoyamaSari.Text = "Tahtayı Boya";
            this.buttonBoyamaSari.UseVisualStyleBackColor = false;
            this.buttonBoyamaSari.Click += new System.EventHandler(this.ImageBoyama);
            // 
            // buttonBoyamaKirmizi
            // 
            this.buttonBoyamaKirmizi.BackColor = System.Drawing.Color.Crimson;
            this.buttonBoyamaKirmizi.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBoyamaKirmizi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBoyamaKirmizi.Location = new System.Drawing.Point(19, 275);
            this.buttonBoyamaKirmizi.Name = "buttonBoyamaKirmizi";
            this.buttonBoyamaKirmizi.Size = new System.Drawing.Size(200, 97);
            this.buttonBoyamaKirmizi.TabIndex = 9;
            this.buttonBoyamaKirmizi.Text = "Tahtayı Boya";
            this.buttonBoyamaKirmizi.UseVisualStyleBackColor = false;
            this.buttonBoyamaKirmizi.Click += new System.EventHandler(this.ImageBoyama);
            // 
            // buttonBoyamaYesil
            // 
            this.buttonBoyamaYesil.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonBoyamaYesil.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBoyamaYesil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBoyamaYesil.Location = new System.Drawing.Point(19, 172);
            this.buttonBoyamaYesil.Name = "buttonBoyamaYesil";
            this.buttonBoyamaYesil.Size = new System.Drawing.Size(200, 97);
            this.buttonBoyamaYesil.TabIndex = 8;
            this.buttonBoyamaYesil.Text = "Tahtayı Boya";
            this.buttonBoyamaYesil.UseVisualStyleBackColor = false;
            this.buttonBoyamaYesil.Click += new System.EventHandler(this.ImageBoyama);
            // 
            // buttonBoyamaMavi
            // 
            this.buttonBoyamaMavi.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBoyamaMavi.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBoyamaMavi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBoyamaMavi.Location = new System.Drawing.Point(19, 72);
            this.buttonBoyamaMavi.Name = "buttonBoyamaMavi";
            this.buttonBoyamaMavi.Size = new System.Drawing.Size(200, 97);
            this.buttonBoyamaMavi.TabIndex = 7;
            this.buttonBoyamaMavi.Text = "Tahtayı Boya";
            this.buttonBoyamaMavi.UseVisualStyleBackColor = false;
            this.buttonBoyamaMavi.Click += new System.EventHandler(this.ImageBoyama);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(869, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 97);
            this.button1.TabIndex = 18;
            this.button1.Text = "Tahtayı Boya";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(869, 579);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 97);
            this.button2.TabIndex = 20;
            this.button2.Text = "Tahtayı Boya";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(869, 476);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 97);
            this.button3.TabIndex = 19;
            this.button3.Text = "Tahtayı Boya";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(869, 276);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 97);
            this.button4.TabIndex = 17;
            this.button4.Text = "Tahtayı Boya";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.ForestGreen;
            this.button5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(869, 173);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 97);
            this.button5.TabIndex = 16;
            this.button5.Text = "Tahtayı Boya";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button6_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(869, 73);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 97);
            this.button6.TabIndex = 15;
            this.button6.Text = "Tahtayı Boya";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonBoyamaPortakal);
            this.Controls.Add(this.buttonBoyamaSiyah);
            this.Controls.Add(this.buttonBoyamaSari);
            this.Controls.Add(this.buttonBoyamaKirmizi);
            this.Controls.Add(this.buttonBoyamaYesil);
            this.Controls.Add(this.buttonBoyamaMavi);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBoyamaPortakal;
        private System.Windows.Forms.Button buttonBoyamaSiyah;
        private System.Windows.Forms.Button buttonBoyamaSari;
        private System.Windows.Forms.Button buttonBoyamaKirmizi;
        private System.Windows.Forms.Button buttonBoyamaYesil;
        private System.Windows.Forms.Button buttonBoyamaMavi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

