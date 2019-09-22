using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Analysis
{
    public class Table
    {
        public List<Group> FirstFollow { get; } = new List<Group>();
        public List<string> Patterns { get; } = new List<string>();
        public List<TableRow> Rows { get; } = new List<TableRow>();
        public virtual List<char> Terminals => this.CollectTerminals(Patterns);
        public virtual List<char> Variables
        {
            get
            {
                var lc = new List<char>();
                foreach (var sp in FirstFollow)
                {
                    lc.Add(sp.Variable);
                }
                return lc;
            }
        }
        public Table(IEnumerable<Group> first_follow, List<string> patterns)
        {
            this.FirstFollow = new List<Group>(first_follow);
            this.Patterns = patterns;
        }
        public List<char> CollectTerminals(List<string> patterns)
        {
            var rights = new List<string>();
            var terminals = new List<char>();
            foreach(var p in patterns)
            {
                rights.Add(p.Substring(3,p.Length-3));
            }
            foreach(var p in rights)
            {
                for(var i=0;i<p.Length;i++)
                {
                    if (!char.IsUpper(p[i]) && !terminals.Contains(p[i]) && p[i] != '@')
                    {
                        //collect terminals only (without @)
                        terminals.Add(p[i]);
                    }
                }
            }
            terminals.Add('#');
            return terminals;
        }

        public List<TableRow> BuildTable()
        {
            foreach (var p in Patterns)
            {
                var lcFirst = FindResultFirst(p[0]);
                var lcFollow = FindResultFollow(p[0]);
                if (p.Substring(1, p.Length - 1) == "->@")
                {
                    lcFollow.Remove('@');
                    Rows.Add(new TableRow(p, lcFollow));
                }
                else
                {
                    if (!char.IsUpper(p[3]))
                    {
                        //terminal
                        var line = new List<char>
                        {
                            p[3]
                        };
                        Rows.Add(new TableRow(p, line));
                    }
                    else
                    {
                        lcFirst.Remove('@');
                        Rows.Add(new TableRow(p, lcFirst));
                    } 
                }
            }
            return this.Rows;
        }
        public List<char> FindResultFirst(char c)
        {
            var lc = new List<char>();
            foreach (var sp in FirstFollow)
            {
                if (c == sp.Variable)
                {
                    foreach (var ch in sp.FIRST)
                    {
                        lc.Add(ch);
                    }
                    break;
                }

            }
            return lc;
        }
        public List<char> FindResultFollow(char c)
        {
            var lc = new List<char>();
            foreach (var sp in FirstFollow)
            {
                if (c == sp.Variable)
                {
                    foreach (var ch in sp.FOLLOW)
                    {
                        lc.Add(ch);
                    }
                    break;
                }

            }
            return lc;
        }
    }
}
