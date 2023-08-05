namespace SAPJointNumberer
{
    partial class SapJointNumberer
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
            this.rename_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rename_button
            // 
            this.rename_button.Location = new System.Drawing.Point(299, 68);
            this.rename_button.Name = "rename_button";
            this.rename_button.Size = new System.Drawing.Size(75, 23);
            this.rename_button.TabIndex = 0;
            this.rename_button.Text = "rename";
            this.rename_button.UseVisualStyleBackColor = true;
            this.rename_button.Click += new System.EventHandler(this.rename_button_Click);
            // 
            // SapJointNumberer
            // 
            this.ClientSize = new System.Drawing.Size(482, 166);
            this.Controls.Add(this.rename_button);
            this.Name = "SapJointNumberer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SapJointNumberer_FormClosed);
            this.Load += new System.EventHandler(this.SapJointNumberer_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button rename_button;
    }
}

