namespace KanbanBoard
{
    partial class Kanban_Boards
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yatayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dikeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üstÜsteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toDoToolStripMenuItem,
            this.doingToolStripMenuItem,
            this.doneToolStripMenuItem,
            this.düzenToolStripMenuItem,
            this.notEkleToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toDoToolStripMenuItem
            // 
            this.toDoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toDoToolStripMenuItem.Name = "toDoToolStripMenuItem";
            this.toDoToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toDoToolStripMenuItem.Text = "ToDo";
            this.toDoToolStripMenuItem.Click += new System.EventHandler(this.toDoToolStripMenuItem_Click);
            // 
            // doingToolStripMenuItem
            // 
            this.doingToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.doingToolStripMenuItem.Name = "doingToolStripMenuItem";
            this.doingToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.doingToolStripMenuItem.Text = "Doing";
            this.doingToolStripMenuItem.Click += new System.EventHandler(this.doingToolStripMenuItem_Click);
            // 
            // doneToolStripMenuItem
            // 
            this.doneToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.doneToolStripMenuItem.Name = "doneToolStripMenuItem";
            this.doneToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.doneToolStripMenuItem.Text = "Done";
            this.doneToolStripMenuItem.Click += new System.EventHandler(this.doneToolStripMenuItem_Click);
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yatayToolStripMenuItem,
            this.dikeyToolStripMenuItem,
            this.üstÜsteToolStripMenuItem});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // yatayToolStripMenuItem
            // 
            this.yatayToolStripMenuItem.Name = "yatayToolStripMenuItem";
            this.yatayToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.yatayToolStripMenuItem.Text = "Yatay";
            this.yatayToolStripMenuItem.Click += new System.EventHandler(this.yatayToolStripMenuItem_Click);
            // 
            // dikeyToolStripMenuItem
            // 
            this.dikeyToolStripMenuItem.Name = "dikeyToolStripMenuItem";
            this.dikeyToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.dikeyToolStripMenuItem.Text = "Dikey";
            this.dikeyToolStripMenuItem.Click += new System.EventHandler(this.dikeyToolStripMenuItem_Click);
            // 
            // üstÜsteToolStripMenuItem
            // 
            this.üstÜsteToolStripMenuItem.Name = "üstÜsteToolStripMenuItem";
            this.üstÜsteToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.üstÜsteToolStripMenuItem.Text = "Üst Üste";
            this.üstÜsteToolStripMenuItem.Click += new System.EventHandler(this.üstÜsteToolStripMenuItem_Click);
            // 
            // notEkleToolStripMenuItem
            // 
            this.notEkleToolStripMenuItem.Name = "notEkleToolStripMenuItem";
            this.notEkleToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.notEkleToolStripMenuItem.Text = "Not Ekle";
            this.notEkleToolStripMenuItem.Click += new System.EventHandler(this.notEkleToolStripMenuItem_Click_2);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.çıkışYapToolStripMenuItem.Text = "Exit";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click_2);
            // 
            // Kanban_Boards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Kanban_Boards";
            this.Text = "Kanban_Boards";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toDoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yatayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dikeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üstÜsteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
    }
}