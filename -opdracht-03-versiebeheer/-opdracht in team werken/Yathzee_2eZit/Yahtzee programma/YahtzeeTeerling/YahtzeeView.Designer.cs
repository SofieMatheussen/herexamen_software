namespace YahtzeeTeerling
{
    partial class YahtzeeView
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
            this.aantalWerpen = new System.Windows.Forms.Label();
            this.lblWorpen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aantalWerpen
            // 
            this.aantalWerpen.AutoSize = true;
            this.aantalWerpen.Location = new System.Drawing.Point(16, 241);
            this.aantalWerpen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aantalWerpen.Name = "aantalWerpen";
            this.aantalWerpen.Size = new System.Drawing.Size(0, 17);
            this.aantalWerpen.TabIndex = 0;
            // 
            // lblWorpen
            // 
            this.lblWorpen.AutoSize = true;
            this.lblWorpen.Location = new System.Drawing.Point(20, 255);
            this.lblWorpen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorpen.Name = "lblWorpen";
            this.lblWorpen.Size = new System.Drawing.Size(132, 17);
            this.lblWorpen.TabIndex = 1;
            this.lblWorpen.Text = "Overige Worpen: 3 ";
            this.lblWorpen.Click += new System.EventHandler(this.lblWorpen_Click);
            // 
            // YahtzeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblWorpen);
            this.Controls.Add(this.aantalWerpen);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "YahtzeeView";
            this.Size = new System.Drawing.Size(257, 282);
            this.Load += new System.EventHandler(this.YahtzeeView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aantalWerpen;
        private System.Windows.Forms.Label lblWorpen;
    }
}
