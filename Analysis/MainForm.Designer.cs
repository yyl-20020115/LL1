namespace Analysis
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TcRight = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RTBShowFirst = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RTBShowFollow = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LVTable = new System.Windows.Forms.ListView();
            this.RTBRules = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonOpenFile = new System.Windows.Forms.Button();
            this.ButtonParse = new System.Windows.Forms.Button();
            this.TcLeft = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.RTBReady = new System.Windows.Forms.RichTextBox();
            this.ButtonFirst = new System.Windows.Forms.Button();
            this.ButtonFollow = new System.Windows.Forms.Button();
            this.ButtonLL1Analysize = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.TcRight.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.TcLeft.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.TcRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TcRight.Controls.Add(this.tabPage1);
            this.TcRight.Controls.Add(this.tabPage2);
            this.TcRight.Controls.Add(this.tabPage3);
            this.TcRight.Location = new System.Drawing.Point(272, 4);
            this.TcRight.Margin = new System.Windows.Forms.Padding(4);
            this.TcRight.Name = "tabControl1";
            this.TcRight.SelectedIndex = 0;
            this.TcRight.Size = new System.Drawing.Size(605, 282);
            this.TcRight.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RTBShowFirst);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(597, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "First集";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RTBShowFirst
            // 
            this.RTBShowFirst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTBShowFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTBShowFirst.Location = new System.Drawing.Point(4, 4);
            this.RTBShowFirst.Margin = new System.Windows.Forms.Padding(4);
            this.RTBShowFirst.Name = "RTBShowFirst";
            this.RTBShowFirst.Size = new System.Drawing.Size(589, 245);
            this.RTBShowFirst.TabIndex = 0;
            this.RTBShowFirst.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RTBShowFollow);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(597, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Follow集";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RTBShowFollow
            // 
            this.RTBShowFollow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTBShowFollow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTBShowFollow.Location = new System.Drawing.Point(4, 4);
            this.RTBShowFollow.Margin = new System.Windows.Forms.Padding(4);
            this.RTBShowFollow.Name = "RTBShowFollow";
            this.RTBShowFollow.Size = new System.Drawing.Size(589, 245);
            this.RTBShowFollow.TabIndex = 0;
            this.RTBShowFollow.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LVTable);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(597, 253);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "LL1分析";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // LVTable
            // 
            this.LVTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVTable.GridLines = true;
            this.LVTable.HideSelection = false;
            this.LVTable.Location = new System.Drawing.Point(4, 4);
            this.LVTable.Margin = new System.Windows.Forms.Padding(4);
            this.LVTable.Name = "LVTable";
            this.LVTable.Size = new System.Drawing.Size(589, 245);
            this.LVTable.TabIndex = 9;
            this.LVTable.UseCompatibleStateImageBehavior = false;
            this.LVTable.View = System.Windows.Forms.View.Details;
            // 
            // rtbRules
            // 
            this.RTBRules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTBRules.ContextMenuStrip = this.contextMenuStrip1;
            this.RTBRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTBRules.Location = new System.Drawing.Point(4, 4);
            this.RTBRules.Margin = new System.Windows.Forms.Padding(4);
            this.RTBRules.Name = "rtbRules";
            this.RTBRules.Size = new System.Drawing.Size(255, 245);
            this.RTBRules.TabIndex = 0;
            this.RTBRules.Text = "E->TA\nA->+TA|$\nT->FB\nB->*FB|$\nF->(E)|i";
            this.RTBRules.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RTB_Grammar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤销ToolStripMenuItem,
            this.toolStripSeparator1,
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.剪切ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 106);
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.撤销ToolStripMenuItem.Text = "撤销";
            this.撤销ToolStripMenuItem.Click += new System.EventHandler(this.UNDO_ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.COPY_ToolStripMenuItem_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.PASTE_ToolStripMenuItem_Click);
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.剪切ToolStripMenuItem.Text = "剪切";
            this.剪切ToolStripMenuItem.Click += new System.EventHandler(this.CUT_ToolStripMenuItem_Click);
            // 
            // ButtonOpenFile
            // 
            this.ButtonOpenFile.Location = new System.Drawing.Point(16, 305);
            this.ButtonOpenFile.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonOpenFile.Name = "ButtonOpenFile";
            this.ButtonOpenFile.Size = new System.Drawing.Size(100, 29);
            this.ButtonOpenFile.TabIndex = 2;
            this.ButtonOpenFile.Text = "打开文件";
            this.ButtonOpenFile.UseVisualStyleBackColor = true;
            this.ButtonOpenFile.Click += new System.EventHandler(this.ButtonOpenFile_Click);
            // 
            // ButtonParse
            // 
            this.ButtonParse.Location = new System.Drawing.Point(140, 305);
            this.ButtonParse.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonParse.Name = "ButtonParse";
            this.ButtonParse.Size = new System.Drawing.Size(100, 29);
            this.ButtonParse.TabIndex = 3;
            this.ButtonParse.Text = "拆分";
            this.ButtonParse.UseVisualStyleBackColor = true;
            this.ButtonParse.Click += new System.EventHandler(this.ButtonParse_Click);
            // 
            // tabControl2
            // 
            this.TcLeft.Controls.Add(this.tabPage4);
            this.TcLeft.Controls.Add(this.tabPage5);
            this.TcLeft.Location = new System.Drawing.Point(3, 4);
            this.TcLeft.Margin = new System.Windows.Forms.Padding(4);
            this.TcLeft.Name = "tabControl2";
            this.TcLeft.SelectedIndex = 0;
            this.TcLeft.Size = new System.Drawing.Size(271, 282);
            this.TcLeft.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.RTBRules);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(263, 253);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "原文法";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.RTBReady);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(263, 253);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "拆分候选式";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // richTextBox5
            // 
            this.RTBReady.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTBReady.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTBReady.Location = new System.Drawing.Point(4, 4);
            this.RTBReady.Margin = new System.Windows.Forms.Padding(4);
            this.RTBReady.Name = "richTextBox5";
            this.RTBReady.ReadOnly = true;
            this.RTBReady.Size = new System.Drawing.Size(255, 245);
            this.RTBReady.TabIndex = 0;
            this.RTBReady.Text = "";
            // 
            // ButtonFirst
            // 
            this.ButtonFirst.Location = new System.Drawing.Point(272, 301);
            this.ButtonFirst.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonFirst.Name = "ButtonFirst";
            this.ButtonFirst.Size = new System.Drawing.Size(145, 35);
            this.ButtonFirst.TabIndex = 6;
            this.ButtonFirst.Text = "First集";
            this.ButtonFirst.UseVisualStyleBackColor = true;
            this.ButtonFirst.Click += new System.EventHandler(this.ButtonCalculateFIRST_Click);
            // 
            // ButtonFollow
            // 
            this.ButtonFollow.Location = new System.Drawing.Point(441, 301);
            this.ButtonFollow.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonFollow.Name = "ButtonFollow";
            this.ButtonFollow.Size = new System.Drawing.Size(133, 35);
            this.ButtonFollow.TabIndex = 7;
            this.ButtonFollow.Text = "Follow集";
            this.ButtonFollow.UseVisualStyleBackColor = true;
            this.ButtonFollow.Click += new System.EventHandler(this.ButtonCalculateFOLLOW_Click);
            // 
            // ButtonLL1Analysize
            // 
            this.ButtonLL1Analysize.Location = new System.Drawing.Point(611, 301);
            this.ButtonLL1Analysize.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonLL1Analysize.Name = "ButtonLL1Analysize";
            this.ButtonLL1Analysize.Size = new System.Drawing.Size(224, 35);
            this.ButtonLL1Analysize.TabIndex = 8;
            this.ButtonLL1Analysize.Text = "LL1分析";
            this.ButtonLL1Analysize.UseVisualStyleBackColor = true;
            this.ButtonLL1Analysize.Click += new System.EventHandler(this.ButtonLL1_Click);
            // 
            // openFileDialog1
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(875, 341);
            this.Controls.Add(this.TcLeft);
            this.Controls.Add(this.ButtonFirst);
            this.Controls.Add(this.ButtonLL1Analysize);
            this.Controls.Add(this.ButtonOpenFile);
            this.Controls.Add(this.ButtonParse);
            this.Controls.Add(this.TcRight);
            this.Controls.Add(this.ButtonFollow);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "LL1分析表";
            this.TcRight.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.TcLeft.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TcRight;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox RTBRules;
        private System.Windows.Forms.RichTextBox RTBShowFirst;
        private System.Windows.Forms.RichTextBox RTBShowFollow;
        private System.Windows.Forms.Button ButtonOpenFile;
        private System.Windows.Forms.Button ButtonParse;
        private System.Windows.Forms.TabControl TcLeft;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.RichTextBox RTBReady;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
        private System.Windows.Forms.Button ButtonFirst;
        private System.Windows.Forms.Button ButtonFollow;
        private System.Windows.Forms.Button ButtonLL1Analysize;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.ListView LVTable;
    }
}

