using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triple_DES_files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            if (ofile.ShowDialog() == DialogResult.OK)
                textBox1.Text = ofile.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {//Tripledes
            try
            {
                triple tr = new triple(textBox2.Text);
                tr.encrypt(textBox1.Text);
                GC.Collect();
                MessageBox.Show("OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //DES
            //try
            //{
            //    encr tr = new encr(textBox2.Text);
            //    tr.encrypt(textBox1.Text);
            //    GC.Collect();
            //    MessageBox.Show("OK");
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                triple tr = new triple(textBox2.Text);
                tr.decrypt(textBox1.Text);
                GC.Collect();
                MessageBox.Show("OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //DES
            //try
            //{
            //    encr tr = new encr(textBox2.Text);
            //    tr.decrypt(textBox1.Text);
            //    GC.Collect();
            //    MessageBox.Show("OK");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
