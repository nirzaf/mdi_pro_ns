using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mdi_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Backup bf = new Backup();
            bf.MdiParent = this;
            bf.BackColor = Color.Yellow;
            bf.ShowIcon = false;
            bf.MaximizeBox = false;
            bf.MinimizeBox = false ;
            //-------------------
            bf.version_label2.Text = "2020";
            bf.version_label2.BackColor = Color.Red;
            //-------------------
            bf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            settings sf = new settings();
            sf.MdiParent = this;
            sf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Backup bf = new Backup();
            //bf.MdiParent = this;
            bf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            settings sf = new settings();
            sf.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mdi_pro.my_forms.test_form f = new mdi_pro.my_forms.test_form();
                f.Show();
        }
    }
}
