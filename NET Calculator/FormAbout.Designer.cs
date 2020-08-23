namespace NET_Calculator
{
    partial class FormAbout
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
            this.LabelAbout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelAbout
            // 
            this.LabelAbout.Location = new System.Drawing.Point(324, 181);
            this.LabelAbout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAbout.Name = "LabelAbout";
            this.LabelAbout.Size = new System.Drawing.Size(400, 150);
            this.LabelAbout.TabIndex = 0;
            this.LabelAbout.Text = "This is a desktop calculator applicattion. \r\n\r\nIt was created with Visual Code an" +
    "d Windows Forms .NET framework.";
            this.LabelAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.LabelAbout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAbout";
            this.Text = "FormAbout";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelAbout;
    }
}