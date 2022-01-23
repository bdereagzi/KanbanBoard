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
    public partial class ToDo : Form
    {
        public void changeLabelText(string s)
        {
            
        }
        public ToDo()
        {
            InitializeComponent();
        }

      


        private void ToDo_Load(object sender, EventArgs e)
        {

        }

        private void lblChar_Click(object sender, EventArgs e)
        {

        }

        private void txtToDo_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "Kalan karakter sayısı:" + (140 - txtToDo.TextLength).ToString();
        }
    }
}
