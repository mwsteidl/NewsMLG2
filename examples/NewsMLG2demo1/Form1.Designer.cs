namespace NewsMLG2demo1
{
    partial class Form1
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mainTC = new System.Windows.Forms.TabControl();
            this.ex1Tpg = new System.Windows.Forms.TabPage();
            this.qsTextEx1Lbl = new System.Windows.Forms.Label();
            this.qsPackageEx1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.qsTextEx1 = new System.Windows.Forms.Button();
            this.ex2Tpg = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.qsPkgEx1Lbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.mainTC.SuspendLayout();
            this.ex1Tpg.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(450, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 396);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(450, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mainTC
            // 
            this.mainTC.Controls.Add(this.ex1Tpg);
            this.mainTC.Controls.Add(this.ex2Tpg);
            this.mainTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTC.Location = new System.Drawing.Point(0, 24);
            this.mainTC.Name = "mainTC";
            this.mainTC.SelectedIndex = 0;
            this.mainTC.Size = new System.Drawing.Size(450, 372);
            this.mainTC.TabIndex = 2;
            // 
            // ex1Tpg
            // 
            this.ex1Tpg.Controls.Add(this.qsPkgEx1Lbl);
            this.ex1Tpg.Controls.Add(this.label1);
            this.ex1Tpg.Controls.Add(this.qsTextEx1Lbl);
            this.ex1Tpg.Controls.Add(this.qsPackageEx1);
            this.ex1Tpg.Controls.Add(this.button2);
            this.ex1Tpg.Controls.Add(this.qsTextEx1);
            this.ex1Tpg.Location = new System.Drawing.Point(4, 22);
            this.ex1Tpg.Name = "ex1Tpg";
            this.ex1Tpg.Padding = new System.Windows.Forms.Padding(3);
            this.ex1Tpg.Size = new System.Drawing.Size(442, 346);
            this.ex1Tpg.TabIndex = 0;
            this.ex1Tpg.Text = "Examples 1";
            this.ex1Tpg.UseVisualStyleBackColor = true;
            // 
            // qsTextEx1Lbl
            // 
            this.qsTextEx1Lbl.AutoSize = true;
            this.qsTextEx1Lbl.Location = new System.Drawing.Point(200, 29);
            this.qsTextEx1Lbl.Name = "qsTextEx1Lbl";
            this.qsTextEx1Lbl.Size = new System.Drawing.Size(22, 13);
            this.qsTextEx1Lbl.TabIndex = 3;
            this.qsTextEx1Lbl.Text = ". . .";
            // 
            // qsPackageEx1
            // 
            this.qsPackageEx1.Location = new System.Drawing.Point(9, 122);
            this.qsPackageEx1.Name = "qsPackageEx1";
            this.qsPackageEx1.Size = new System.Drawing.Size(185, 23);
            this.qsPackageEx1.TabIndex = 2;
            this.qsPackageEx1.Text = "QuickStart Package Example 1";
            this.qsPackageEx1.UseVisualStyleBackColor = true;
            this.qsPackageEx1.Click += new System.EventHandler(this.qsPackageEx1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // qsTextEx1
            // 
            this.qsTextEx1.Location = new System.Drawing.Point(9, 24);
            this.qsTextEx1.Name = "qsTextEx1";
            this.qsTextEx1.Size = new System.Drawing.Size(185, 23);
            this.qsTextEx1.TabIndex = 0;
            this.qsTextEx1.Text = "QuickStart Text Example 1";
            this.qsTextEx1.UseVisualStyleBackColor = true;
            this.qsTextEx1.Click += new System.EventHandler(this.qsTextEx1_Click);
            // 
            // ex2Tpg
            // 
            this.ex2Tpg.Location = new System.Drawing.Point(4, 22);
            this.ex2Tpg.Name = "ex2Tpg";
            this.ex2Tpg.Padding = new System.Windows.Forms.Padding(3);
            this.ex2Tpg.Size = new System.Drawing.Size(442, 346);
            this.ex2Tpg.TabIndex = 1;
            this.ex2Tpg.Text = "Examples 2";
            this.ex2Tpg.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = ". . .";
            // 
            // qsPkgEx1Lbl
            // 
            this.qsPkgEx1Lbl.AutoSize = true;
            this.qsPkgEx1Lbl.Location = new System.Drawing.Point(200, 127);
            this.qsPkgEx1Lbl.Name = "qsPkgEx1Lbl";
            this.qsPkgEx1Lbl.Size = new System.Drawing.Size(22, 13);
            this.qsPkgEx1Lbl.TabIndex = 5;
            this.qsPkgEx1Lbl.Text = ". . .";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 418);
            this.Controls.Add(this.mainTC);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "NewsML-G2 Demo 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainTC.ResumeLayout(false);
            this.ex1Tpg.ResumeLayout(false);
            this.ex1Tpg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl mainTC;
        private System.Windows.Forms.TabPage ex1Tpg;
        private System.Windows.Forms.Button qsPackageEx1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button qsTextEx1;
        private System.Windows.Forms.TabPage ex2Tpg;
        private System.Windows.Forms.Label qsTextEx1Lbl;
        private System.Windows.Forms.Label qsPkgEx1Lbl;
        private System.Windows.Forms.Label label1;
    }
}

