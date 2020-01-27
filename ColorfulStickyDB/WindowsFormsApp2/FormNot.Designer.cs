namespace WindowsFormsApp2
{
    partial class FormNot
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
            this.tblPanelButun = new System.Windows.Forms.TableLayoutPanel();
            this.tblPanelBaslik = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.tblPanelButun.SuspendLayout();
            this.tblPanelBaslik.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPanelButun
            // 
            this.tblPanelButun.ColumnCount = 1;
            this.tblPanelButun.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanelButun.Controls.Add(this.tblPanelBaslik, 0, 0);
            this.tblPanelButun.Controls.Add(this.txtNot, 0, 1);
            this.tblPanelButun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanelButun.Location = new System.Drawing.Point(0, 0);
            this.tblPanelButun.Name = "tblPanelButun";
            this.tblPanelButun.RowCount = 2;
            this.tblPanelButun.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.88889F));
            this.tblPanelButun.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.11111F));
            this.tblPanelButun.Size = new System.Drawing.Size(466, 450);
            this.tblPanelButun.TabIndex = 2;
            // 
            // tblPanelBaslik
            // 
            this.tblPanelBaslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tblPanelBaslik.ColumnCount = 4;
            this.tblPanelBaslik.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblPanelBaslik.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tblPanelBaslik.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblPanelBaslik.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblPanelBaslik.Controls.Add(this.btnDelete, 3, 0);
            this.tblPanelBaslik.Controls.Add(this.button3, 2, 0);
            this.tblPanelBaslik.Controls.Add(this.btnAdd, 0, 0);
            this.tblPanelBaslik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanelBaslik.Location = new System.Drawing.Point(0, 0);
            this.tblPanelBaslik.Margin = new System.Windows.Forms.Padding(0);
            this.tblPanelBaslik.Name = "tblPanelBaslik";
            this.tblPanelBaslik.RowCount = 1;
            this.tblPanelBaslik.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelBaslik.Size = new System.Drawing.Size(466, 67);
            this.tblPanelBaslik.TabIndex = 2;
            this.tblPanelBaslik.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.tblPanelBaslik.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.tblPanelBaslik.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(397, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 61);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "x";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(328, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 61);
            this.button3.TabIndex = 2;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 61);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNot
            // 
            this.txtNot.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtNot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNot.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNot.Location = new System.Drawing.Point(3, 70);
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(460, 377);
            this.txtNot.TabIndex = 3;
            this.txtNot.Text = "Not1";
            this.txtNot.TextChanged += new System.EventHandler(this.txtNot_TextChanged);
            // 
            // FormNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.tblPanelButun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNot";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNot_FormClosing);
            this.tblPanelButun.ResumeLayout(false);
            this.tblPanelButun.PerformLayout();
            this.tblPanelBaslik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPanelButun;
        private System.Windows.Forms.TableLayoutPanel tblPanelBaslik;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNot;
    }
}

