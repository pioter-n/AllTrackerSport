﻿using Strava.Activities;
using System;
using System.Windows.Forms;

namespace AllTrackerSport
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AccordionControlElement6_Click(object sender, EventArgs e)
        {
            xtraUserControl1.Controls.Add(XtraUserControl1.Instance);
            XtraUserControl1.Instance.Dock = DockStyle.Fill;
            XtraUserControl1.Instance.BringToFront();
        }

        private void AccordionControlElement2_Click(object sender, EventArgs e)
        {

            xtraUserControl1.Controls.Add(XtraUserControl1.Instance);
            XtraUserControl1.Instance.Dock = DockStyle.Fill;
            XtraUserControl1.Instance.BringToFront();
        }

        private void AccordionControlElement3_Click(object sender, EventArgs e)
        {
            xtraUserControl1.Controls.Add(XtraUserControl2.Instance);
            XtraUserControl2.Instance.Dock = DockStyle.Fill;
            XtraUserControl2.Instance.BringToFront();
        }

        private void AccordionControlElement3_Click_1(object sender, EventArgs e)
        {
            xtraUserControl1.Controls.Add(XtraUserControl2.Instance);
            XtraUserControl2.Instance.Dock = DockStyle.Fill;
            XtraUserControl2.Instance.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
