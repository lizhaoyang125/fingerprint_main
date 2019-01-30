using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form_initial : Form
    {
        public Form_initial()
        {
            InitializeComponent();
        }

        private void button_ToRegisterWindow_Click(object sender, EventArgs e)
        {
            Form_register f1 = new Form_register();
            f1.ShowDialog();
        }

        private void button_normalCard_Click(object sender, EventArgs e)
        {
            Form_normal_card f1 = new Form_normal_card();
            f1.ShowDialog();
        }

        private void button_linshituo_Click(object sender, EventArgs e)
        {
            Form_linshituo f1 = new Form_linshituo();
            f1.ShowDialog();
        }
    }
}
