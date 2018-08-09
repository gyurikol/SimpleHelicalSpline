﻿namespace SimpleHelicalSpline
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.txtRotations = new System.Windows.Forms.TextBox();
            this.txtPitch = new System.Windows.Forms.TextBox();
            this.lstDirection = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cboPPR = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text File|*.txt";
            this.saveFileDialog1.Title = "Save Helical Spline File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diameter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rotations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pitch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direction";
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(68, 10);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(204, 20);
            this.txtDiameter.TabIndex = 4;
            this.txtDiameter.Text = "0";
            // 
            // txtRotations
            // 
            this.txtRotations.Location = new System.Drawing.Point(68, 36);
            this.txtRotations.Name = "txtRotations";
            this.txtRotations.Size = new System.Drawing.Size(204, 20);
            this.txtRotations.TabIndex = 5;
            this.txtRotations.Text = "0";
            // 
            // txtPitch
            // 
            this.txtPitch.Location = new System.Drawing.Point(68, 62);
            this.txtPitch.Name = "txtPitch";
            this.txtPitch.Size = new System.Drawing.Size(204, 20);
            this.txtPitch.TabIndex = 6;
            this.txtPitch.Text = "0";
            // 
            // lstDirection
            // 
            this.lstDirection.FormattingEnabled = true;
            this.lstDirection.Items.AddRange(new object[] {
            "Clockwise",
            "Counter-Clockwise"});
            this.lstDirection.Location = new System.Drawing.Point(68, 88);
            this.lstDirection.Name = "lstDirection";
            this.lstDirection.Size = new System.Drawing.Size(204, 30);
            this.lstDirection.TabIndex = 7;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(68, 152);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(204, 30);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create Helical Spline";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cboPPR
            // 
            this.cboPPR.FormattingEnabled = true;
            this.cboPPR.Location = new System.Drawing.Point(117, 125);
            this.cboPPR.Name = "cboPPR";
            this.cboPPR.Size = new System.Drawing.Size(155, 21);
            this.cboPPR.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Points Per Rotation";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 196);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboPPR);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lstDirection);
            this.Controls.Add(this.txtPitch);
            this.Controls.Add(this.txtRotations);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "CAD CAM Services - Helix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.TextBox txtRotations;
        private System.Windows.Forms.TextBox txtPitch;
        private System.Windows.Forms.ListBox lstDirection;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cboPPR;
        private System.Windows.Forms.Label label5;
    }
}

