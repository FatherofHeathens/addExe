using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addExe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int Num1 = Convert.ToInt32(this.Num1.Text);
                int Num2 = Convert.ToInt32(this.Num2.Text);
                int Sum = Num1 + Num2;
                this.totalSum.Text = Convert.ToString(Sum);
            }
            catch
            {
                MessageBox.Show("Enter numbers only please!");
            }
        }
    }
}
