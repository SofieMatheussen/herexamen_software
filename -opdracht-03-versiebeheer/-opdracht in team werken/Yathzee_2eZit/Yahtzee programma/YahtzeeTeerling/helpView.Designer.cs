namespace YahtzeeTeerling
{
    partial class helpView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helpButton
            // 
            this.helpButton.ForeColor = System.Drawing.Color.Red;
            this.helpButton.Location = new System.Drawing.Point(12, 15);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(99, 28);
            this.helpButton.TabIndex = 1;
            this.helpButton.Text = "help!";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // helpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.helpButton);
            this.Location = new System.Drawing.Point(835, 266);
            this.Name = "helpView";
            this.Size = new System.Drawing.Size(123, 55);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button helpButton;
    }
}
