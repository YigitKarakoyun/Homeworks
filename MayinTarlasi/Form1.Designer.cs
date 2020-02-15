namespace _13_MayinTarlasi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yeniOyunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBaslik = new System.Windows.Forms.Panel();
            this.tableLayoutPanelBaslik = new System.Windows.Forms.TableLayoutPanel();
            this.labelBaslik = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSure = new System.Windows.Forms.Label();
            this.labelSkor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMayinTarlasi = new System.Windows.Forms.Panel();
            this.fpMayinTarlasi = new System.Windows.Forms.FlowLayoutPanel();
            this.timerSure = new System.Windows.Forms.Timer(this.components);
            this.timerSkor = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panelBaslik.SuspendLayout();
            this.tableLayoutPanelBaslik.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelMayinTarlasi.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniOyunToolStripMenuItem,
            this.hakkımdaToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yeniOyunToolStripMenuItem
            // 
            this.yeniOyunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolayToolStripMenuItem,
            this.ortaToolStripMenuItem,
            this.zorToolStripMenuItem});
            this.yeniOyunToolStripMenuItem.Name = "yeniOyunToolStripMenuItem";
            this.yeniOyunToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.yeniOyunToolStripMenuItem.Text = "YeniOyun";
            // 
            // kolayToolStripMenuItem
            // 
            this.kolayToolStripMenuItem.Name = "kolayToolStripMenuItem";
            this.kolayToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.kolayToolStripMenuItem.Text = "Kolay";
            this.kolayToolStripMenuItem.Click += new System.EventHandler(this.kolayToolStripMenuItem_Click);
            // 
            // ortaToolStripMenuItem
            // 
            this.ortaToolStripMenuItem.Name = "ortaToolStripMenuItem";
            this.ortaToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.ortaToolStripMenuItem.Text = "Orta";
            this.ortaToolStripMenuItem.Click += new System.EventHandler(this.ortaToolStripMenuItem_Click);
            // 
            // zorToolStripMenuItem
            // 
            this.zorToolStripMenuItem.Name = "zorToolStripMenuItem";
            this.zorToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.zorToolStripMenuItem.Text = "Zor";
            this.zorToolStripMenuItem.Click += new System.EventHandler(this.zortToolStripMenuItem_Click);
            // 
            // hakkımdaToolStripMenuItem
            // 
            this.hakkımdaToolStripMenuItem.Name = "hakkımdaToolStripMenuItem";
            this.hakkımdaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.hakkımdaToolStripMenuItem.Text = "Hakkımda";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // panelBaslik
            // 
            this.panelBaslik.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBaslik.Controls.Add(this.tableLayoutPanelBaslik);
            this.panelBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBaslik.Location = new System.Drawing.Point(0, 24);
            this.panelBaslik.Name = "panelBaslik";
            this.panelBaslik.Size = new System.Drawing.Size(524, 90);
            this.panelBaslik.TabIndex = 1;
            // 
            // tableLayoutPanelBaslik
            // 
            this.tableLayoutPanelBaslik.ColumnCount = 1;
            this.tableLayoutPanelBaslik.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBaslik.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBaslik.Controls.Add(this.labelBaslik, 0, 0);
            this.tableLayoutPanelBaslik.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanelBaslik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBaslik.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBaslik.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelBaslik.Name = "tableLayoutPanelBaslik";
            this.tableLayoutPanelBaslik.RowCount = 2;
            this.tableLayoutPanelBaslik.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.88889F));
            this.tableLayoutPanelBaslik.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.11111F));
            this.tableLayoutPanelBaslik.Size = new System.Drawing.Size(524, 90);
            this.tableLayoutPanelBaslik.TabIndex = 0;
            // 
            // labelBaslik
            // 
            this.labelBaslik.BackColor = System.Drawing.Color.LightSlateGray;
            this.labelBaslik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBaslik.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaslik.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBaslik.Location = new System.Drawing.Point(0, 0);
            this.labelBaslik.Margin = new System.Windows.Forms.Padding(0);
            this.labelBaslik.Name = "labelBaslik";
            this.labelBaslik.Size = new System.Drawing.Size(524, 44);
            this.labelBaslik.TabIndex = 1;
            this.labelBaslik.Text = "MAYIN TARLASI";
            this.labelBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.Controls.Add(this.labelSure, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelSkor, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 44);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(524, 46);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // labelSure
            // 
            this.labelSure.BackColor = System.Drawing.Color.LightSlateGray;
            this.labelSure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSure.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSure.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelSure.Location = new System.Drawing.Point(350, 1);
            this.labelSure.Margin = new System.Windows.Forms.Padding(0);
            this.labelSure.Name = "labelSure";
            this.labelSure.Size = new System.Drawing.Size(173, 44);
            this.labelSure.TabIndex = 2;
            this.labelSure.Text = "Süre: 00:00:00";
            this.labelSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSkor
            // 
            this.labelSkor.BackColor = System.Drawing.Color.LightSlateGray;
            this.labelSkor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSkor.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold);
            this.labelSkor.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelSkor.Location = new System.Drawing.Point(1, 1);
            this.labelSkor.Margin = new System.Windows.Forms.Padding(0);
            this.labelSkor.Name = "labelSkor";
            this.labelSkor.Size = new System.Drawing.Size(171, 44);
            this.labelSkor.TabIndex = 0;
            this.labelSkor.Text = "Skor: 0";
            this.labelSkor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.BackgroundImage = global::_13_MayinTarlasi.Properties.Resources.Smiling_Emoji_with_Smiling_Eyes_large;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(173, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 44);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnEmoji_Click);
            // 
            // panelMayinTarlasi
            // 
            this.panelMayinTarlasi.BackColor = System.Drawing.Color.SlateGray;
            this.panelMayinTarlasi.Controls.Add(this.fpMayinTarlasi);
            this.panelMayinTarlasi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMayinTarlasi.Location = new System.Drawing.Point(0, 114);
            this.panelMayinTarlasi.Name = "panelMayinTarlasi";
            this.panelMayinTarlasi.Size = new System.Drawing.Size(524, 447);
            this.panelMayinTarlasi.TabIndex = 2;
            // 
            // fpMayinTarlasi
            // 
            this.fpMayinTarlasi.BackColor = System.Drawing.Color.Transparent;
            this.fpMayinTarlasi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpMayinTarlasi.Location = new System.Drawing.Point(0, 0);
            this.fpMayinTarlasi.Name = "fpMayinTarlasi";
            this.fpMayinTarlasi.Size = new System.Drawing.Size(524, 447);
            this.fpMayinTarlasi.TabIndex = 0;
            // 
            // timerSure
            // 
            this.timerSure.Enabled = true;
            this.timerSure.Interval = 1000;
            this.timerSure.Tick += new System.EventHandler(this.timerSure_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 561);
            this.Controls.Add(this.panelMayinTarlasi);
            this.Controls.Add(this.panelBaslik);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelBaslik.ResumeLayout(false);
            this.tableLayoutPanelBaslik.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelMayinTarlasi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniOyunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ortaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.Panel panelBaslik;
        private System.Windows.Forms.Panel panelMayinTarlasi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBaslik;
        private System.Windows.Forms.Label labelBaslik;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelSure;
        private System.Windows.Forms.Label labelSkor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerSure;
        private System.Windows.Forms.Timer timerSkor;
        private System.Windows.Forms.FlowLayoutPanel fpMayinTarlasi;
    }
}

