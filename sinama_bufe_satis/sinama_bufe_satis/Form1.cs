using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinama_bufe_satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int miktar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int  toplm,mısır = 15, su = 5, cay = 9, bilet = 25;
            int s1 = Convert.ToInt32(textBox1.Text), s2 = Convert.ToInt32(textBox2.Text), s3 = Convert.ToInt32(textBox3.Text), s4 = Convert.ToInt32(textBox4.Text);
            toplm = s1 * mısır + s2 * cay + s3 * su + s4 * bilet;
            miktar = miktar+toplm;
            label16.Text = toplm.ToString();
            label13.Text = miktar.ToString();
            
        }

        
    }
}
