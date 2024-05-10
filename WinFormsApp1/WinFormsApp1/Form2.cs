using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Доступ предоставлен!");
            Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Доступ запрещён!");
            Close();
        }
    }
}
