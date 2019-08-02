namespace LibraryProject2
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.nameLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.library = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnSellBook = new System.Windows.Forms.Button();
            this.btnShowAllBooks = new System.Windows.Forms.Button();
            this.btnShowAllAuthors = new System.Windows.Forms.Button();
            this.btnShowReceipts = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.AntiqueWhite;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.viewMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(617, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(44, 24);
            this.fileMenu.Text = "&File";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(105, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(53, 24);
            this.viewMenu.Text = "&View";
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.statusBarToolStripMenuItem.Text = "&Status Bar";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.AntiqueWhite;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameLable,
            this.library});
            this.statusStrip.Location = new System.Drawing.Point(0, 388);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(617, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // nameLable
            // 
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(116, 20);
            this.nameLable.Text = "employee name";
            // 
            // library
            // 
            this.library.Name = "library";
            this.library.Size = new System.Drawing.Size(51, 20);
            this.library.Text = "library";
            // 
            // btnSellBook
            // 
            this.btnSellBook.BackColor = System.Drawing.Color.DarkRed;
            this.btnSellBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSellBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSellBook.Location = new System.Drawing.Point(12, 35);
            this.btnSellBook.Name = "btnSellBook";
            this.btnSellBook.Size = new System.Drawing.Size(196, 165);
            this.btnSellBook.TabIndex = 3;
            this.btnSellBook.Text = "Sell a Book";
            this.btnSellBook.UseVisualStyleBackColor = false;
            this.btnSellBook.Click += new System.EventHandler(this.btnSellBook_Click);
            // 
            // btnShowAllBooks
            // 
            this.btnShowAllBooks.BackColor = System.Drawing.Color.SandyBrown;
            this.btnShowAllBooks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAllBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowAllBooks.Location = new System.Drawing.Point(214, 35);
            this.btnShowAllBooks.Name = "btnShowAllBooks";
            this.btnShowAllBooks.Size = new System.Drawing.Size(189, 165);
            this.btnShowAllBooks.TabIndex = 4;
            this.btnShowAllBooks.Text = "Show all available Books";
            this.btnShowAllBooks.UseVisualStyleBackColor = false;
            this.btnShowAllBooks.Click += new System.EventHandler(this.btnShowAllBooks_Click);
            // 
            // btnShowAllAuthors
            // 
            this.btnShowAllAuthors.BackColor = System.Drawing.Color.DarkGreen;
            this.btnShowAllAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAllAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllAuthors.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowAllAuthors.Location = new System.Drawing.Point(409, 35);
            this.btnShowAllAuthors.Name = "btnShowAllAuthors";
            this.btnShowAllAuthors.Size = new System.Drawing.Size(188, 165);
            this.btnShowAllAuthors.TabIndex = 5;
            this.btnShowAllAuthors.Text = "show all authors";
            this.btnShowAllAuthors.UseVisualStyleBackColor = false;
            this.btnShowAllAuthors.Click += new System.EventHandler(this.btnShowAllAuthors_Click);
            // 
            // btnShowReceipts
            // 
            this.btnShowReceipts.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnShowReceipts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowReceipts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowReceipts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowReceipts.Location = new System.Drawing.Point(12, 206);
            this.btnShowReceipts.Name = "btnShowReceipts";
            this.btnShowReceipts.Size = new System.Drawing.Size(196, 168);
            this.btnShowReceipts.TabIndex = 6;
            this.btnShowReceipts.Text = "show all selled books";
            this.btnShowReceipts.UseVisualStyleBackColor = false;
            this.btnShowReceipts.Click += new System.EventHandler(this.btnShowReceipts_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SteelBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(214, 206);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(189, 168);
            this.button5.TabIndex = 7;
            this.button5.Text = "See all current employee";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(409, 206);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 168);
            this.button6.TabIndex = 8;
            this.button6.Text = "LogOut";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 413);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnShowReceipts);
            this.Controls.Add(this.btnShowAllAuthors);
            this.Controls.Add(this.btnShowAllBooks);
            this.Controls.Add(this.btnSellBook);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "project2";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripStatusLabel nameLable;
        private System.Windows.Forms.ToolStripStatusLabel library;
        private System.Windows.Forms.Button btnSellBook;
        private System.Windows.Forms.Button btnShowAllBooks;
        private System.Windows.Forms.Button btnShowAllAuthors;
        private System.Windows.Forms.Button btnShowReceipts;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}



