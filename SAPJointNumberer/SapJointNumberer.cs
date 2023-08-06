using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPJointNumberer
{
    public partial class SapJointNumberer : Form
    {
        public SapJointNumberer()
        {
            InitializeComponent();
        }

        private void rename_button_Click(object sender, EventArgs e)
        {
            string[] names = PointManager.GetSelectedPointsNames();
            PointManager.RenamePointsWithNames(names);
            SapVewManager.RefreshWindow();
        }

        private void SapJointNumberer_Load(object sender, EventArgs e)
        {
            SAP.ConnectToSap();
            prefix_box.Text = string.Empty;
            startNum_box.Text = "1";
            x_label.Text = $"Order by X: {x_bar.Value.ToString()}";
            y_label.Text = $"Order by Y: {y_bar.Value.ToString()}";
            z_label.Text = $"Order by Z: {z_bar.Value.ToString()}";
        }

        private void SapJointNumberer_FormClosed(object sender, FormClosedEventArgs e)
        {
            SAP.CloseConnectionToSap();
        }

        private void prefix_box_TextChanged(object sender, EventArgs e)
        {
            PointManager.pointPrefix = prefix_box.Text;
        }

        private void startNum_box_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(startNum_box.Text,out int statrtNumber))
            {
                PointManager.pointStartNumber = statrtNumber;
            }
        }

        private void x_bar_Scroll(object sender, EventArgs e)
        {
            x_label.Text = $"Order by X: {x_bar.Value.ToString()}";
        }

        private void y_bar_Scroll(object sender, EventArgs e)
        {
            y_label.Text = $"Order by Y: {y_bar.Value.ToString()}";
        }

        private void z_bar_Scroll(object sender, EventArgs e)
        {
            z_label.Text = $"Order by Z: {z_bar.Value.ToString()}";
        }
    }
}
