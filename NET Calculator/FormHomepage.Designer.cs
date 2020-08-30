namespace NET_Calculator
{
    partial class FormHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomepage));
            this.ButtonCalculatorForm = new System.Windows.Forms.Button();
            this.ButtonAboutForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonCalculatorForm
            // 
            this.ButtonCalculatorForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonCalculatorForm.Location = new System.Drawing.Point(189, 34);
            this.ButtonCalculatorForm.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCalculatorForm.Name = "ButtonCalculatorForm";
            this.ButtonCalculatorForm.Size = new System.Drawing.Size(200, 125);
            this.ButtonCalculatorForm.TabIndex = 0;
            this.ButtonCalculatorForm.Text = "Calculator";
            this.ButtonCalculatorForm.UseVisualStyleBackColor = true;
            this.ButtonCalculatorForm.Click += new System.EventHandler(this.ButtonCalculatorForm_Click_1);
            // 
            // ButtonAboutForm
            // 
            this.ButtonAboutForm.Location = new System.Drawing.Point(189, 206);
            this.ButtonAboutForm.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAboutForm.Name = "ButtonAboutForm";
            this.ButtonAboutForm.Size = new System.Drawing.Size(200, 125);
            this.ButtonAboutForm.TabIndex = 1;
            this.ButtonAboutForm.Text = "About";
            this.ButtonAboutForm.UseVisualStyleBackColor = true;
            this.ButtonAboutForm.Click += new System.EventHandler(this.ButtonAboutForm_Click);
            // 
            // FormHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.ButtonAboutForm);
            this.Controls.Add(this.ButtonCalculatorForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHomepage_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonCalculatorForm;
        private System.Windows.Forms.Button ButtonAboutForm;
    }
}

