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
    public partial class Kanban_Boards : Form
    {
        Form formToDo = new ToDo();
        Form formDoing = new Doing();
        Form formDone = new Done();
        public Kanban_Boards()
        {
            InitializeComponent();
           
        }

        private void kullanıcıİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            FormAc(ref form1);
        }

        private void toDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            FormAc(ref formToDo);
        }

        private void doingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormAc(ref formDoing);
        }

        private void doneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormAc(ref formDone);
        }
        void FormAc(ref Form form)
        {
            Form f = form;
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Text == f.Text)
                {
                    mdiChild.BringToFront();
                    return;
                }
            }
            f.MdiParent = this;
            f.Show();
        }

        private void üstÜsteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void dikeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void yatayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

       
      

        
    
        private void çıkışYapToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void notEkleToolStripMenuItem_Click_2(object sender, EventArgs e)
        {

            TextBox textbox = new TextBox();
            textbox.Top = 0;
            textbox.Left = 0;
            textbox.Width = 200;
            textbox.Height = 150;
            textbox.Multiline = true;
            textbox.MaxLength = 140;
           
            formToDo.Controls.Add(textbox);
            formDoing.Controls.Add(textbox);
            formDone.Controls.Add(textbox);

            textbox.TextChanged += new EventHandler(TextBox_TextChanged);
            void TextBox_TextChanged(object sender2, EventArgs e2)
            {
                


            }


        }
    }
}
