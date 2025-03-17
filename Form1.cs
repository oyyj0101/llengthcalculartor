using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace llengthcalculartor
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            double douCM;

            douCM = Convert.ToDouble(txtCM.Text);

            txtM.Text = string.Format("{0:0.##########}", douCM / 100);
            txtKM.Text = string.Format("{0:0.##########}", douCM / 100000);
            txtIn.Text = string.Format("{0:0.##########}", douCM / 2.54);
            txtFt.Text = string.Format("{0:0.##########}", douCM / 30.48);
            txtYard.Text = string.Format("{0:0.##########}", douCM / 91.44);
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            double douM;

            douM = Convert.ToDouble(txtM.Text);

            txtCM.Text = string.Format("{0:0.##########}", douM / 0.01);
            txtKM.Text = string.Format("{0:0.##########}", douM / 1000);
            txtIn.Text = string.Format("{0:0.##########}", douM / 0.0254);
            txtFt.Text = string.Format("{0:0.##########}", douM / 0.3048);
            txtYard.Text = string.Format("{0:0.##########}", douM / 0.9144);
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            double douKM;

            douKM = Convert.ToDouble(txtKM.Text);

            txtCM.Text = string.Format("{0:0.##########}", douKM / 0.00001);
            txtM.Text = string.Format("{0:0.##########}", douKM / 0.001);
            txtIn.Text = string.Format("{0:0.##########}", douKM / 0.0000254);
            txtFt.Text = string.Format("{0:0.##########}", douKM / 0.0003048);
            txtYard.Text = string.Format("{0:0.##########}", douKM / 0.0009144);
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            double douIn;

            douIn = Convert.ToDouble(txtIn.Text);

            txtCM.Text = string.Format("{0:0.##########}", douIn / 0.393701);
            txtM.Text = string.Format("{0:0.##########}", douIn / 39.3701);
            txtKM.Text = string.Format("{0:0.##########}", douIn / 39370.1);
            txtFt.Text = string.Format("{0:0.##########}", douIn / 12);
            txtYard.Text = string.Format("{0:0.##########}", douIn / 36);
        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            double douFt;

            douFt = Convert.ToDouble(txtFt.Text);

            txtCM.Text = string.Format("{0:0.##########}", douFt / 0.0328084);
            txtM.Text = string.Format("{0:0.##########}", douFt / 3.28084);
            txtKM.Text = string.Format("{0:0.##########}", douFt / 3280.84);
            txtIn.Text = string.Format("{0:0.##########}", douFt / 0.0833333);
            txtYard.Text = string.Format("{0:0.##########}", douFt / 3);
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            double douYard;

            douYard = Convert.ToDouble(txtYard.Text);

            txtCM.Text = string.Format("{0:0.##########}", douYard / 0.0109361);
            txtM.Text = string.Format("{0:0.##########}", douYard / 1.09361);
            txtKM.Text = string.Format("{0:0.##########}", douYard / 1093.61);
            txtIn.Text = string.Format("{0:0.##########}", douYard / 0.0277778);
            txtFt.Text = string.Format("{0:0.##########}", douYard / 0.333333);
        }
    }
}
