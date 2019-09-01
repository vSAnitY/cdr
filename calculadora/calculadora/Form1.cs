using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {

        double pri;
        double seg;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        clase.ClsSuma obj = new clase.ClsSuma();
        clase.ClsResta obj2 = new clase.ClsResta();
        clase.ClsMulti obj3 = new clase.ClsMulti();
        clase.ClsDivision obj4 = new clase.ClsDivision();
        clase.ClsPorcentaje obj5 = new clase.ClsPorcentaje();


        private void TBXSCREEN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button19_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "0";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "1";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "2";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "3";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "5";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "6";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "7";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "9";
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + ".";

        }

        private void Button15_Click(object sender, EventArgs e)
        {
            op = "+";
            pri = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();

        }

        private void Button11_Click(object sender, EventArgs e)
        {
            op = "/";
            pri = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();

        }

        private void Button12_Click(object sender, EventArgs e)
        {
            op = "*";
            pri = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            op = "-";
            pri = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();

        }

        private void Button16_Click(object sender, EventArgs e)
        {
            op = "%";
            pri = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();

        }

        private void Button17_Click(object sender, EventArgs e)
        {
            seg = double.Parse(tbxScreen.Text);

            double su;
            double re;
            double mu;
            double di;
            double po;

            switch (op)
            {
                case "+":
                    su = obj.sumar((pri), (seg));
                    tbxScreen.Text = su.ToString();
                    break;
                case "-":
                    re = obj2.resta((pri), (seg));
                    tbxScreen.Text = re.ToString();
                    break;
                case "*":
                    mu = obj3.mult((pri), (seg));
                    tbxScreen.Text = mu.ToString();
                    break;
                case "/":
                    di = obj4.divi((pri), (seg));
                    tbxScreen.Text = di.ToString();
                    break;
                case "%":
                    po = obj5.porcentaje((pri), (seg));
                    tbxScreen.Text = po.ToString();
                    break;

            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            {
                if (tbxScreen.Text.Length == 1)
                    tbxScreen.Text = "";
                else
                    tbxScreen.Text = tbxScreen.Text.Substring(0, tbxScreen.Text.Length - 1);

            }

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
        }
    }
}
