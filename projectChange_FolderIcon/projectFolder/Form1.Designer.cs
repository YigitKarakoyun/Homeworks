namespace projectFolder
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnChangeFolderIcon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangeFolderIcon
            // 
            this.btnChangeFolderIcon.Location = new System.Drawing.Point(26, 22);
            this.btnChangeFolderIcon.Name = "btnChangeFolderIcon";
            this.btnChangeFolderIcon.Size = new System.Drawing.Size(157, 73);
            this.btnChangeFolderIcon.TabIndex = 0;
            this.btnChangeFolderIcon.Text = "Change Folder Icon";
            this.btnChangeFolderIcon.UseVisualStyleBackColor = true;
            this.btnChangeFolderIcon.Click += new System.EventHandler(this.btnChangeFolderIcon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChangeFolderIcon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnChangeFolderIcon;
    }
}

