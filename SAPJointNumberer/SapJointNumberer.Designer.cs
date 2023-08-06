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
            this.x_bar = new System.Windows.Forms.TrackBar();
            this.x_label = new System.Windows.Forms.Label();
            this.numbering_label = new System.Windows.Forms.Label();
            this.y_bar = new System.Windows.Forms.TrackBar();
            this.z_bar = new System.Windows.Forms.TrackBar();
            this.y_label = new System.Windows.Forms.Label();
            this.z_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.x_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // rename_button
            // 
            this.rename_button.Location = new System.Drawing.Point(217, 28);
            this.rename_button.Name = "rename_button";
            this.rename_button.Size = new System.Drawing.Size(75, 23);
            this.rename_button.TabIndex = 0;
            this.rename_button.Text = "numbering";
            this.rename_button.UseVisualStyleBackColor = true;
            this.rename_button.Click += new System.EventHandler(this.rename_button_Click);
            // 
            // startNum_box
            // 
            this.startNum_box.Location = new System.Drawing.Point(142, 28);
            this.startNum_box.Name = "startNum_box";
            this.startNum_box.Size = new System.Drawing.Size(53, 20);
            this.startNum_box.TabIndex = 1;
            this.startNum_box.TextChanged += new System.EventHandler(this.startNum_box_TextChanged);
            // 
            // prefix_box
            // 
            this.prefix_box.Location = new System.Drawing.Point(20, 28);
            this.prefix_box.Name = "prefix_box";
            this.prefix_box.Size = new System.Drawing.Size(100, 20);
            this.prefix_box.TabIndex = 2;
            this.prefix_box.TextChanged += new System.EventHandler(this.prefix_box_TextChanged);
            // 
            // pref_label
            // 
            this.pref_label.AutoSize = true;
            this.pref_label.Location = new System.Drawing.Point(17, 10);
            this.pref_label.Name = "pref_label";
            this.pref_label.Size = new System.Drawing.Size(32, 13);
            this.pref_label.TabIndex = 3;
            this.pref_label.Text = "prefix";
            // 
            // startNum_label
            // 
            this.startNum_label.AutoSize = true;
            this.startNum_label.Location = new System.Drawing.Point(142, 10);
            this.startNum_label.Name = "startNum_label";
            this.startNum_label.Size = new System.Drawing.Size(65, 13);
            this.startNum_label.TabIndex = 4;
            this.startNum_label.Text = "start number";
            // 
            // x_bar
            // 
            this.x_bar.LargeChange = 3;
            this.x_bar.Location = new System.Drawing.Point(96, 98);
            this.x_bar.Maximum = 3;
            this.x_bar.Minimum = -3;
            this.x_bar.Name = "x_bar";
            this.x_bar.Size = new System.Drawing.Size(196, 45);
            this.x_bar.TabIndex = 5;
            this.x_bar.Value = 3;
            this.x_bar.Scroll += new System.EventHandler(this.x_bar_Scroll);
            // 
            // x_label
            // 
            this.x_label.AutoSize = true;
            this.x_label.Location = new System.Drawing.Point(20, 98);
            this.x_label.Name = "x_label";
            this.x_label.Size = new System.Drawing.Size(14, 13);
            this.x_label.TabIndex = 6;
            this.x_label.Text = "X";
            // 
            // numbering_label
            // 
            this.numbering_label.AutoSize = true;
            this.numbering_label.Location = new System.Drawing.Point(68, 69);
            this.numbering_label.Name = "numbering_label";
            this.numbering_label.Size = new System.Drawing.Size(163, 13);
            this.numbering_label.TabIndex = 7;
            this.numbering_label.Text = "Numbering priority by coordinates";
            // 
            // y_bar
            // 
            this.y_bar.LargeChange = 3;
            this.y_bar.Location = new System.Drawing.Point(96, 150);
            this.y_bar.Maximum = 3;
            this.y_bar.Minimum = -3;
            this.y_bar.Name = "y_bar";
            this.y_bar.Size = new System.Drawing.Size(196, 45);
            this.y_bar.TabIndex = 8;
            this.y_bar.Value = 2;
            this.y_bar.Scroll += new System.EventHandler(this.y_bar_Scroll);
            // 
            // z_bar
            // 
            this.z_bar.LargeChange = 3;
            this.z_bar.Location = new System.Drawing.Point(96, 202);
            this.z_bar.Maximum = 3;
            this.z_bar.Minimum = -3;
            this.z_bar.Name = "z_bar";
            this.z_bar.Size = new System.Drawing.Size(196, 45);
            this.z_bar.TabIndex = 9;
            this.z_bar.Value = 1;
            this.z_bar.Scroll += new System.EventHandler(this.z_bar_Scroll);
            // 
            // y_label
            // 
            this.y_label.AutoSize = true;
            this.y_label.Location = new System.Drawing.Point(20, 150);
            this.y_label.Name = "y_label";
            this.y_label.Size = new System.Drawing.Size(14, 13);
            this.y_label.TabIndex = 10;
            this.y_label.Text = "Y";
            // 
            // z_label
            // 
            this.z_label.AutoSize = true;
            this.z_label.Location = new System.Drawing.Point(20, 202);
            this.z_label.Name = "z_label";
            this.z_label.Size = new System.Drawing.Size(14, 13);
            this.z_label.TabIndex = 11;
            this.z_label.Text = "Z";
            // 
            // SapJointNumberer
            // 
            this.ClientSize = new System.Drawing.Size(315, 252);
            this.Controls.Add(this.z_label);
            this.Controls.Add(this.y_label);
            this.Controls.Add(this.z_bar);
            this.Controls.Add(this.y_bar);
            this.Controls.Add(this.numbering_label);
            this.Controls.Add(this.x_label);
            this.Controls.Add(this.x_bar);
            this.Controls.Add(this.startNum_label);
            this.Controls.Add(this.pref_label);
            this.Controls.Add(this.prefix_box);
            this.Controls.Add(this.startNum_box);
            this.Controls.Add(this.rename_button);
            this.Name = "SapJointNumberer";
            this.Text = "Sap Joints Numberer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SapJointNumberer_FormClosed);
            this.Load += new System.EventHandler(this.SapJointNumberer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.x_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button rename_button;
        private System.Windows.Forms.TextBox startNum_box;
        private System.Windows.Forms.TextBox prefix_box;
        private System.Windows.Forms.Label pref_label;
        private System.Windows.Forms.Label startNum_label;
        private System.Windows.Forms.TrackBar x_bar;
        private System.Windows.Forms.Label x_label;
        private System.Windows.Forms.Label numbering_label;
        private System.Windows.Forms.TrackBar y_bar;
        private System.Windows.Forms.TrackBar z_bar;
        private System.Windows.Forms.Label y_label;
        private System.Windows.Forms.Label z_label;
    }
}

