using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Analysis
{
    public partial class MainForm : Form
    {
        protected Arithmetic arithmetic;
        protected Table table;
        protected List<string> patterns = new List<string>();
        protected List<TableRow> rows;
        protected List<char> terminals;
        protected List<char> variables;
        public MainForm()
        {
            InitializeComponent();
            RTBShowFirst.ReadOnly = true;
            RTBShowFollow.ReadOnly = true;

            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.InitialDirectory = @"E:\";
  
            ButtonFirst.Enabled = false;
            ButtonFollow.Enabled = false;
            ButtonLL1Analysize.Enabled = false;
        }

        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)                //文件读取
            {
                using var fs = new FileStream(ofd.FileName, FileMode.Open);
                using var sr = new StreamReader(fs, Encoding.Default);//用FileStream对象实例化一个StreamReader对象 
                var s = sr.ReadToEnd();
                RTBRules.Text = s;
                TcLeft.SelectedIndex = 0;
            }
      
        }

        private void ButtonParse_Click(object sender, EventArgs e)
        {
            patterns.Clear();
            var g = new Grammar();
            var pts = RTBRules.Lines;

            for (var i = 0; i < pts.Length; i++)
            {
                var s = pts[i].Replace(" ", "");

                if (!string.IsNullOrEmpty(s))
                {
                    g.ParseAndAddProduction(s);
                }
            }
            ButtonFirst.Enabled = true;
            
            var builder = new StringBuilder();

            TcLeft.SelectedIndex = 1;

            foreach (var s in g.Productions)
            {
               patterns.Add(s);
               builder.AppendLine(s);
            }
            RTBReady.Text = builder.ToString();
        }
        private void ButtonCalculateFIRST_Click(object sender, EventArgs e)
        {
            arithmetic= new Arithmetic(patterns);
            arithmetic.BuildFIRSTs();

            ButtonFollow.Enabled = true;
            TcRight.SelectedIndex = 0;
            var builder = new StringBuilder();;
            foreach (var sp in arithmetic.GROUPS.Values)
            {
                builder.AppendLine(sp.Variable + "\t"+ 
                    sp.FIRST.ConvertAll(c=>c.ToString()).Aggregate((a,n)=>a + " " + n));
            }
            RTBShowFirst.Text = builder.ToString();
        }

        private void ButtonCalculateFOLLOW_Click(object sender, EventArgs e)
        {
            arithmetic.BuildFOLLOWs();
            TcRight.SelectedIndex = 1;
            var builder = new StringBuilder(); ;
            foreach (var sp in arithmetic.GROUPS.Values)
            {
                builder.AppendLine(sp.Variable + "\t" +
                   sp.FOLLOW.ConvertAll(c => c.ToString()).Aggregate((a, n) => a + " " + n));
            }
            RTBShowFollow.Text = builder.ToString();
            ButtonLL1Analysize.Enabled = true;
        }

        private void ButtonLL1_Click(object sender, EventArgs e)
        {
            LVTable.Items.Clear();
            LVTable.Columns.Clear();
            TcRight.SelectedIndex = 2;

            table = new Table(arithmetic.GROUPS.Values, patterns);
           
            rows = table.BuildTable();

            this.variables = table.Variables;
            this.terminals = table.Terminals;


            int w = LVTable.Width / (terminals.Count+1);
            LVTable.Columns.Add("TABLE", w, HorizontalAlignment.Left);
            foreach (var c in this.terminals)
            {
                LVTable.Columns.Add(c.ToString(), w, HorizontalAlignment.Left);
            }
            foreach (var ch in this.variables)
            {
                var lv = new ListViewItem();

                lv.SubItems[0].Text = ch.ToString();

                var ls = new string[terminals.Count];
                for (int i = 0; i < ls.Length; i++)
                {
                    ls[i] = string.Empty;
                }
                foreach(var s in GetResultPatternsByVariableOnLeft(ch))
                {
                    var i = 1;
                    while (i < terminals.Count+1)
                    {
                        if (GetResultTerminals(s).Contains(char.Parse(LVTable.Columns[i].Text)))
                        {
                            ls[i-1] = s;
                        }
                        i++;
                    }
                }
                lv.SubItems.AddRange(ls);
                LVTable.Items.Add(lv);
            }
            
        }
        public List<string> GetResultPatternsByVariableOnLeft(char c)
        {
            var ls = new List<string>();
            foreach (var ts in rows)
            {
                if (c == ts.Pattern[0])
                {
                    ls.Add(ts.Pattern);
                }
            }
            return ls;
        }
        public List<char> GetResultTerminals(string s)
        {
            var l = new List<char>();
            foreach (var ts in rows)
            {
                if (s == ts.Pattern)
                {
                    l = ts.Terminals;
                    break;
                }
            }
            return l;
        }
        private void RTB_Grammar_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                RTBRules.ContextMenuStrip.Show();
            }
        }
        private void UNDO_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTBRules.Undo();
            RTBRules.ClearUndo();
        }
        private void COPY_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RTBRules.SelectionLength > 0)
            {
                RTBRules.Copy();
            }
        }
        private void PASTE_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                if (this.RTBRules.SelectionLength > 0)
                {
                    this.RTBRules.SelectionStart = this.RTBRules.SelectionStart + this.RTBRules.SelectionLength;
                }
                this.RTBRules.Paste();
            }   

        }
        private void CUT_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RTBRules.SelectedText != string.Empty)
            {
                RTBRules.Cut();
            }
        }
    }
}
