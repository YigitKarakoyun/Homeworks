namespace ToDoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelBaslik = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelAyarlar = new System.Windows.Forms.Panel();
            this.lblAyarlar = new System.Windows.Forms.Label();
            this.panelEkle = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelSil = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelBaslik.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelAyarlar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBaslik
            // 
            this.panelBaslik.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelBaslik.Controls.Add(this.tableLayoutPanel1);
            this.panelBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBaslik.Location = new System.Drawing.Point(0, 0);
            this.panelBaslik.Margin = new System.Windows.Forms.Padding(0);
            this.panelBaslik.Name = "panelBaslik";
            this.panelBaslik.Size = new System.Drawing.Size(400, 50);
            this.panelBaslik.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.48252F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.51748F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Controls.Add(this.panelAyarlar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelEkle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.tableLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panelAyarlar
            // 
            this.panelAyarlar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelAyarlar.BackgroundImage")));
            this.panelAyarlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelAyarlar.Controls.Add(this.lblAyarlar);
            this.panelAyarlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAyarlar.Location = new System.Drawing.Point(284, 0);
            this.panelAyarlar.Margin = new System.Windows.Forms.Padding(0);
            this.panelAyarlar.Name = "panelAyarlar";
            this.panelAyarlar.Size = new System.Drawing.Size(64, 50);
            this.panelAyarlar.TabIndex = 3;
            // 
            // lblAyarlar
            // 
            this.lblAyarlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAyarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAyarlar.Location = new System.Drawing.Point(0, 0);
            this.lblAyarlar.Name = "lblAyarlar";
            this.lblAyarlar.Size = new System.Drawing.Size(64, 50);
            this.lblAyarlar.TabIndex = 0;
            this.lblAyarlar.Text = "...";
            this.lblAyarlar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAyarlar.Click += new System.EventHandler(this.label1_Click);
            this.lblAyarlar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblAyarlar_MouseDown);
            // 
            // panelEkle
            // 
            this.panelEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEkle.BackgroundImage")));
            this.panelEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEkle.Location = new System.Drawing.Point(0, 0);
            this.panelEkle.Margin = new System.Windows.Forms.Padding(0);
            this.panelEkle.Name = "panelEkle";
            this.panelEkle.Size = new System.Drawing.Size(49, 50);
            this.panelEkle.TabIndex = 0;
            this.panelEkle.Click += new System.EventHandler(this.panelEkle_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelSil);
            this.panel3.Location = new System.Drawing.Point(348, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(50, 50);
            this.panel3.TabIndex = 1;
            // 
            // panelSil
            // 
            this.panelSil.BackgroundImage = global::ToDoList.Properties.Resources.cop;
            this.panelSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSil.Location = new System.Drawing.Point(0, 0);
            this.panelSil.Margin = new System.Windows.Forms.Padding(0);
            this.panelSil.Name = "panelSil";
            this.panelSil.Size = new System.Drawing.Size(50, 50);
            this.panelSil.TabIndex = 1;
            this.panelSil.Click += new System.EventHandler(this.panelSil_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 350);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panelBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\"";
            this.panelBaslik.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelAyarlar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBaslik;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelEkle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelAyarlar;
        private System.Windows.Forms.Panel panelSil;
        private System.Windows.Forms.Label lblAyarlar;
    }
}

