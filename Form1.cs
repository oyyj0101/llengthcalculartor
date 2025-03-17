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
            string strInput;
            strInput = txtCM.Text; // 將txtCM文字框的值放入strInput變數
            double douCM;

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douCM) == true)
            {
                txtM.Text = string.Format("{0:0.##########}", douCM / 100);
                txtKM.Text = string.Format("{0:0.##########}", douCM / 100000);
                txtIn.Text = string.Format("{0:0.##########}", douCM / 2.54);
                txtFt.Text = string.Format("{0:0.##########}", douCM / 30.48);
                txtYard.Text = string.Format("{0:0.##########}", douCM / 91.44);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "請輸入數字";
                txtCM.Text = "";
            }
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            string strInput;
            strInput = txtM.Text; // 將txtCM文字框的值放入strInput變數
            double douM;

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douM) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douM / 0.01);
                txtKM.Text = string.Format("{0:0.##########}", douM / 1000);
                txtIn.Text = string.Format("{0:0.##########}", douM / 0.0254);
                txtFt.Text = string.Format("{0:0.##########}", douM / 0.3048);
                txtYard.Text = string.Format("{0:0.##########}", douM / 0.9144);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "請輸入數字";
                txtM.Text = "";
            }
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            string strInput;
            strInput = txtKM.Text; // 將txtCM文字框的值放入strInput變數
            double douKM;

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douKM) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douKM / 0.00001);
                txtM.Text = string.Format("{0:0.##########}", douKM / 0.001);
                txtIn.Text = string.Format("{0:0.##########}", douKM / 0.0000254);
                txtFt.Text = string.Format("{0:0.##########}", douKM / 0.0003048);
                txtYard.Text = string.Format("{0:0.##########}", douKM / 0.0009144);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "請輸入數字";
                txtKM.Text = "";
            }
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            string strInput;
            strInput = txtIn.Text; // 將txtCM文字框的值放入strInput變數
            double douIn;

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douIn) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douIn / 0.393701);
                txtM.Text = string.Format("{0:0.##########}", douIn / 39.3701);
                txtKM.Text = string.Format("{0:0.##########}", douIn / 39370.1);
                txtFt.Text = string.Format("{0:0.##########}", douIn / 12);
                txtYard.Text = string.Format("{0:0.##########}", douIn / 36);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "請輸入數字";
                txtIn.Text = "";
            }
        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            string strInput;
            strInput = txtFt.Text; // 將txtCM文字框的值放入strInput變數
            double douFt;

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douFt) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douFt / 0.0328084);
                txtM.Text = string.Format("{0:0.##########}", douFt / 3.28084);
                txtKM.Text = string.Format("{0:0.##########}", douFt / 3280.84);
                txtIn.Text = string.Format("{0:0.##########}", douFt / 0.0833333);
                txtYard.Text = string.Format("{0:0.##########}", douFt / 3);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "請輸入數字";
                txtFt.Text = "";
            }
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            string strInput;
            strInput = txtYard.Text; // 將txtCM文字框的值放入strInput變數
            double douYard;

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douYard) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douYard / 0.0109361);
                txtM.Text = string.Format("{0:0.##########}", douYard / 1.09361);
                txtKM.Text = string.Format("{0:0.##########}", douYard / 1093.61);
                txtIn.Text = string.Format("{0:0.##########}", douYard / 0.0277778);
                txtFt.Text = string.Format("{0:0.##########}", douYard / 0.333333);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtInfo.Text = "請輸入數字";
                txtYard.Text = "";
            }
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";
            txtInfo.Text = "";
        }
    }
}
