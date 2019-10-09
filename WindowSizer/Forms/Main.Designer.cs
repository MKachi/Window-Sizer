namespace WindowSizer.Forms
{
    partial class Main
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
            this.styleForm1 = new WindowSizer.Theme.StyleForm();
            this.SuspendLayout();
            // 
            // styleForm1
            // 
            this.styleForm1.BackColor = System.Drawing.Color.Aqua;
            this.styleForm1.Location = new System.Drawing.Point(0, 0);
            this.styleForm1.MaximumSize = new System.Drawing.Size(999, 32);
            this.styleForm1.MinimumSize = new System.Drawing.Size(0, 32);
            this.styleForm1.Name = "styleForm1";
            this.styleForm1.Size = new System.Drawing.Size(49, 32);
            this.styleForm1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(433, 370);
            this.Controls.Add(this.styleForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private Theme.StyleForm styleForm1;
    }
}