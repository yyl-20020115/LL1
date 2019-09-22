using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Analysis
{
    public class Table
    {
        public Dictionary<char,Group> Groups { get; } = new Dictionary<char, Group>();
        public List<string> Patterns { get; } = new List<string>();
        public List<TableData> Data { get; } = new List<TableData>();
        public virtual List<char> Terminals => CollectTerminals(Patterns);
        public virtual List<char> Variables => new List<char>(this.Groups.Keys);
        public Table(Dictionary<char,Group> groups, List<string> patterns)
        {
            this.Groups = groups;
            this.Patterns = patterns;
        }
        public static List<char> CollectTerminals(List<string> patterns)
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

        public List<TableData> BuildTable()
        {
            foreach (var p in Patterns)
            {
                var FIRST = FindFIRST(p[0]);
                var FOLLOW = FindFOLLOW(p[0]);
                //empty
                if (p.Substring(1, p.Length - 1) == "->@")
                {
                    FOLLOW.Remove('@');
                    Data.Add(new TableData(p, FOLLOW));
                }
                else //not empty
                {
                    //terminal
                    if (!char.IsUpper(p[3]))
                    {
                        var line = new List<char>
                        {
                            p[3]
                        };
                        Data.Add(new TableData(p, line));
                    }
                    else
                    {
                        FIRST.Remove('@');
                        Data.Add(new TableData(p, FIRST));
                    } 
                }
            }
            return this.Data;
        }
        public List<char> FindFIRST(char c) => this.Groups.TryGetValue(c, out var group) ?
                group.FIRST.ToList() : new List<char>();
        public List<char> FindFOLLOW(char c) => this.Groups.TryGetValue(c, out var group) ?
                group.FOLLOW.ToList() : new List<char>();
    }
}
