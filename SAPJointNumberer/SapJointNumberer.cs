﻿using System;
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
        }

        private void SapJointNumberer_Load(object sender, EventArgs e)
        {
            SAP.ConnectToSap();
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
    }
}
