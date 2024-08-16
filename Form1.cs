using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public partial class Form1 : Form
    {      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
        }

        private void bntCalc_Click(object sender, EventArgs e)
        {

        }

        private void bnt1_Click(object sender, EventArgs e)
        {
            int bnt1 = 1; 
            txtN1.Text = txtN1.Text+Convert.ToString(bnt1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void bnt2_Click(object sender, EventArgs e)
        {
            int bnt2 =2;
            txtN1.Text = txtN1.Text + Convert.ToString(bnt2);
        }

        private void bnt3_Click(object sender, EventArgs e)
        {
            int bnt3 = 3;
            txtN1.Text = txtN1.Text + Convert.ToString(bnt3);
        }

        private void bnt4_Click(object sender, EventArgs e)
        {
            int bnt4 = 4;
            txtN1.Text = txtN1.Text + Convert.ToString(bnt4);
        }

        private void bnt5_Click(object sender, EventArgs e)
        {
            int bnt5 = 5;
            txtN1.Text = txtN1.Text + Convert.ToString(bnt5);
        }

        private void bnt6_Click(object sender, EventArgs e)
        {
            int bnt6 = 6;
            txtN1.Text = txtN1.Text + Convert.ToString(bnt6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bnt7 = 7;
            txtN1.Text = txtN1.Text + Convert.ToString(bnt7);
        }

        private void bnt8_Click(object sender, EventArgs e)
        {
            int bnt8 = 8;
            txtN1.Text = txtN1.Text + Convert.ToString(bnt8);
        }

        private void bnt9_Click(object sender, EventArgs e)
        {
            int bnt9 = 9;
            txtN1.Text = txtN1.Text + Convert.ToString(bnt9);
        }

        private void bntPonto_Click(object sender, EventArgs e)
        {
            string bntPonto = ".";
            txtN1.Text = txtN1.Text + bntPonto;
        }

        private void bnt0_Click(object sender, EventArgs e)
        {
            int bnt0 = 0;
            txtN1.Text = txtN1.Text + Convert.ToString(bnt0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void txtN2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void bntSoma_Click(object sender, EventArgs e)
        {
            txtN1.Text += " + ";
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void bntIgual_Click(object sender, EventArgs e)
        {                         
                var dataTable = new System.Data.DataTable();
                var resultado = dataTable.Compute(txtN1.Text, string.Empty);
                txtN1.Text = Convert.ToSingle(resultado).ToString();                        
        }

        private void bntSub_Click(object sender, EventArgs e)
        {
            txtN1.Text += " - ";
        }

        private void bntMult_Click(object sender, EventArgs e)
        {
            txtN1.Text += " * ";
        }

        private void bntDiv_Click(object sender, EventArgs e)
        {
            txtN1.Text += " / ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string c = txtN1.Text;
            c = c.Substring(0, c.Count() - 1);
            txtN1.Text = c;

        }
    }
}
