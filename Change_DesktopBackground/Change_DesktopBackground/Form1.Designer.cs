namespace Change_DesktopBackground
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
            this.btnChangeDesktopBackground = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangeDesktopBackground
            // 
            this.btnChangeDesktopBackground.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChangeDesktopBackground.Location = new System.Drawing.Point(40, 12);
            this.btnChangeDesktopBackground.Name = "btnChangeDesktopBackground";
            this.btnChangeDesktopBackground.Size = new System.Drawing.Size(173, 114);
            this.btnChangeDesktopBackground.TabIndex = 0;
            this.btnChangeDesktopBackground.Text = "Change Desktop Background";
            this.btnChangeDesktopBackground.UseVisualStyleBackColor = true;
            this.btnChangeDesktopBackground.Click += new System.EventHandler(this.btnChangeDesktopBackground_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChangeDesktopBackground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChangeDesktopBackground;
    }
}

