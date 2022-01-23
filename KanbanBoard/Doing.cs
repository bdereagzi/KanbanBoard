using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanBoard
{
    public partial class Doing : Form
    {
        public Doing()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblDoing.Text = "Kalan karakter sayısı:" + (140 - textBox1.TextLength).ToString();
        }
    }
}
