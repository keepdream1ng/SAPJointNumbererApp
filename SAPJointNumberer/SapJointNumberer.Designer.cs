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
            this.startNum_box = new System.Windows.Forms.TextBox();
            this.prefix_box = new System.Windows.Forms.TextBox();
            this.pref_label = new System.Windows.Forms.Label();
            this.startNum_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rename_button
            // 
            this.rename_button.Location = new System.Drawing.Point(256, 27);
            this.rename_button.Name = "rename_button";
            this.rename_button.Size = new System.Drawing.Size(75, 23);
            this.rename_button.TabIndex = 0;
            this.rename_button.Text = "rename";
            this.rename_button.UseVisualStyleBackColor = true;
            this.rename_button.Click += new System.EventHandler(this.rename_button_Click);
            // 
            // startNum_box
            // 
            this.startNum_box.Location = new System.Drawing.Point(181, 27);
            this.startNum_box.Name = "startNum_box";
            this.startNum_box.Size = new System.Drawing.Size(53, 20);
            this.startNum_box.TabIndex = 1;
            this.startNum_box.TextChanged += new System.EventHandler(this.startNum_box_TextChanged);
            // 
            // prefix_box
            // 
            this.prefix_box.Location = new System.Drawing.Point(59, 27);
            this.prefix_box.Name = "prefix_box";
            this.prefix_box.Size = new System.Drawing.Size(100, 20);
            this.prefix_box.TabIndex = 2;
            this.prefix_box.TextChanged += new System.EventHandler(this.prefix_box_TextChanged);
            // 
            // pref_label
            // 
            this.pref_label.AutoSize = true;
            this.pref_label.Location = new System.Drawing.Point(56, 9);
            this.pref_label.Name = "pref_label";
            this.pref_label.Size = new System.Drawing.Size(32, 13);
            this.pref_label.TabIndex = 3;
            this.pref_label.Text = "prefix";
            // 
            // startNum_label
            // 
            this.startNum_label.AutoSize = true;
            this.startNum_label.Location = new System.Drawing.Point(181, 9);
            this.startNum_label.Name = "startNum_label";
            this.startNum_label.Size = new System.Drawing.Size(65, 13);
            this.startNum_label.TabIndex = 4;
            this.startNum_label.Text = "start number";
            // 
            // SapJointNumberer
            // 
            this.ClientSize = new System.Drawing.Size(403, 166);
            this.Controls.Add(this.startNum_label);
            this.Controls.Add(this.pref_label);
            this.Controls.Add(this.prefix_box);
            this.Controls.Add(this.startNum_box);
            this.Controls.Add(this.rename_button);
            this.Name = "SapJointNumberer";
            this.Text = "Sap Joints Numberer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SapJointNumberer_FormClosed);
            this.Load += new System.EventHandler(this.SapJointNumberer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button rename_button;
        private System.Windows.Forms.TextBox startNum_box;
        private System.Windows.Forms.TextBox prefix_box;
        private System.Windows.Forms.Label pref_label;
        private System.Windows.Forms.Label startNum_label;
    }
}

