using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMaq.comida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn4.BackColor = Color.LightBlue;
            btn4.ForeColor = Color.DodgerBlue;

            lbl9.Show();
            txtvalor.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btn5.BackColor = Color.LightBlue;
            btn5.ForeColor = Color.DodgerBlue;

            lbl9.Show();
            txtvalor.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            btn1.BackColor = Color.LightBlue;
            btn1.ForeColor = Color.DodgerBlue; 
            
            lbl9.Show();
            txtvalor.Show();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            btn1.BackColor = Color.Gainsboro;
            btn1.ForeColor = Color.Black;
            
        }

        private void txtvalor_TextChanged(object sender, EventArgs e)
        {
            btn1.BackColor = Color.Gainsboro;
            btn1.ForeColor = Color.Black;
            btn2.BackColor = Color.Gainsboro;
            btn2.ForeColor = Color.Black;
            btn3.BackColor = Color.Gainsboro;
            btn3.ForeColor = Color.Black;
            btn4.BackColor = Color.Gainsboro;
            btn4.ForeColor = Color.Black;
            btn5.BackColor = Color.Gainsboro;
            btn5.ForeColor = Color.Black;
            btn6.BackColor = Color.Gainsboro;
            btn6.ForeColor = Color.Black;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            btn2.BackColor = Color.LightBlue;
            btn2.ForeColor = Color.DodgerBlue;

            lbl9.Show();
            txtvalor.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.BackColor = Color.LightBlue;
            btn3.ForeColor = Color.DodgerBlue;

            lbl9.Show();
            txtvalor.Show();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn6.BackColor = Color.LightBlue;
            btn6.ForeColor = Color.DodgerBlue;

            lbl9.Show();
            txtvalor.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double produto = 8.50;
            double valor = double.Parse(txtvalor.Text);
            double conta = valor - produto;
            if (conta < 0)
            {
                MessageBox.Show("Você não tem saldo suficiente");

            }
            else
            {
                MessageBox.Show("Produto comprado com sucesso");
            }
        }
    }
}
