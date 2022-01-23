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
    public partial class Done : Form
    {
        public Done()
        {
            InitializeComponent();
        }

        private void lblDone_Click(object sender, EventArgs e)
        {
          
        }
       
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblDone.Text = "Kalan karakter sayısı:" + (140 - textBox1.TextLength).ToString();
        }
    }
}
