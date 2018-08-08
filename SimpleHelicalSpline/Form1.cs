﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleHelicalSpline
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            // select list item clockwise by default
            lstDirection.SelectedIndex = 0;

        }

        /// <summary>
        /// Create helical spline with filled out variables considered
        /// </summary>
        /// <param name="sender">Create Button object sending message to function</param>
        /// <param name="e">Event arguemmtns of Create Button Click</param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Classes.HSBuilder HSB = new Classes.HSBuilder(
                Double.Parse(txtDiameter.Text),
                Double.Parse(txtRotations.Text),
                Double.Parse(txtPitch.Text),
                (Classes.HSBuilder.clockDirection)lstDirection.SelectedIndex
                );

            // savefile dialog setup
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter(saveFileDialog1.OpenFile());
                writer.Write(HSB.GetHelicalSplineFileData());
                writer.Dispose();
                writer.Close();
                MessageBox.Show("File Complete");
            }
        }
    }
}
