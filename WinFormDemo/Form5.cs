using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDemo
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtName.Text);
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void btnDeletename_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void btnclearList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
        }
    }
}
