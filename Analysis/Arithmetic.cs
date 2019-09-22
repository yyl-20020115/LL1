using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Analysis
{
    public class Arithmetic
    {
        public List<string> Patterns = new List<string>();
        public Dictionary<char, Group> GROUPS { get; } = new Dictionary<char, Group>();
        public Arithmetic(List<string> Patterns)
        {
            this.Patterns = Patterns;
        }
        protected List<string> FindPatternByDefinition(char variable)
        {
            var ps = new List<string>();
            foreach (var p in this.Patterns)
            {
                if (variable == p[0])
                {
                    ps.Add(p);
                }
            }
            return ps;
        }
        protected void BuildFIRST(char pre, char variable)
        {
            var patterns = this.FindPatternByDefinition(variable);
            foreach (var pattern in patterns)
            {
                //X->Y
                //X->a
                var c = pattern[3];
                if (IsVariable(c))
                {
                    this.BuildFIRST(pre, c);
                }
                else
                {
                    this.AddToFIRST(pre, c);
                }
            }
        }
        public void BuildFIRSTs()
        {
            this.GROUPS.Clear();
            foreach (var c in GetDefinitions())
            {
                this.BuildFIRST(c,c);
            }
            CombineFIRSTsIncludingEPS();
        }
        protected List<char> GetDefinitions()           //获取候选式左边的非终结符
        {
            var lc = new List<char>();
            foreach (var p in this.Patterns)
            {
                var c = p[0];
                if (!lc.Contains(c))
                {
                    lc.Add(c);
                }
            }
            return lc;
        }
        protected void CombineFIRSTsIncludingEPS()     //含有空
        {
            //checking all nonterminals
            foreach (var s in GROUPS.Values)
            {
                var patterns = this.FindPatternByDefinition(s.Variable);
                var e_count = 0;
                //checking this pattern p
                foreach (var p in patterns)
                {
                    //if p is eps
                    if (p.Substring(1, p.Length - 1) == "->@")
                    {
                        e_count++;
                    }
                }
                //checking this pattern p
                foreach (var p in patterns.Where(pt => pt.Length > 4))
                {
                    var i = 3;
                    var @continue = true;
                    //check until first terminal
                    while (i < p.Length && IsVariable(p[i]) && @continue)
                    {
                        var group = this.GROUPS.Values.FirstOrDefault(g => g.Variable == p[i]);
                        //having it in FIRSTs
                        if (group != null)
                        {
                            //this group has eps
                            if (group.FIRST.Contains('@'))
                            {
                                var eps_count = s.FIRST.Count(c => c == '@');
                                while (eps_count - e_count > 0)
                                {
                                    s.FIRST.Remove('@');
                                    eps_count--;
                                }
                                foreach (var ch in group.FIRST)
                                {
                                    if (!s.FIRST.Contains(ch) && ch != '@')
                                    {
                                        s.AddFirst(ch);
                                    }
                                }
                            }
                            else
                            {
                                @continue = false;
                                break;
                            }
                        }

                        i++;
                    }
                    //this is terminal, include the terminal if not included.
                    if (i < p.Length && IsTerminal(p[i]))
                    {
                        if (!s.FIRST.Contains(p[i]))
                        {
                            s.AddFirst(p[i]);
                        }
                    }
                }
            }
        }
        protected List<string> FindRightContainerByVariable(char c)
        {
            var ps = new List<string>();
            foreach (var p in Patterns)
            {
                for (int i = 3; i < p.Length; i++)
                {
                    if (c == p[i] && !ps.Contains(p))
                    {
                        ps.Add(p);
                    }
                }
            }
            return ps;
        }
        protected bool IsStartVariable(char c)
        {
            return (this.Patterns.Count>0 && this.Patterns[0].Length>0) && (c == this.Patterns[0][0]);
        }

        protected virtual void AddToFIRST(char c, char first)
        {
            if (this.GROUPS.TryGetValue(c, out var group))
            {
                group.AddFirst(first);
            }
            else
            {
                this.GROUPS[c] = new Group(c, first, true);
            }
        }
        protected virtual void AddToFOLLOW(char c,char follow)
        {
            if(this.GROUPS.TryGetValue(c,out var group))
            {
                group.AddFollow(follow);
            }
            else
            {
                this.GROUPS[c] = new Group(c, follow,false);
            }
        }
        protected virtual List<char> GetFIRST(char c)
        {
            var lc = new List<char>();
            if(this.GROUPS.TryGetValue(c,out var group))
            {
                lc.AddRange(group.FIRST);
            }
            return lc;
        }
        protected List<char> GetFOLLOW(char c)
        {
            var lc = new List<char>();
            if (this.GROUPS.TryGetValue(c, out var group))
            {
                lc.AddRange(group.FOLLOW);
            }
            return lc;
        }
        protected virtual bool IsVariable(char c)
        {
            return char.IsUpper(c);
        }
        protected virtual bool IsTerminal(char c)
        {
            return !char.IsUpper(c);
        }
        public void BuildFOLLOW(char c)
        {
            if (this.IsStartVariable(c))
            {
                AddToFOLLOW(c,'#');
            }
            foreach (var pattern in this.FindRightContainerByVariable(c))
            {
                //only one right, like: T->X
                if (pattern.Length == 4)
                {
                    foreach (var ch in this.GetFOLLOW(pattern[0]))
                    {
                        if (!GetFOLLOW(c).Contains(ch))
                        {
                            this.AddToFOLLOW(c,ch);
                        }
                    }
                }
                else
                {
                    var s = pattern;
                    var currentIndex = pattern.IndexOf(c);
                    while (currentIndex > 0)
                    {
                        //this is last 
                        if (currentIndex == s.Length - 1)
                        {
                            foreach (var ch in GetFOLLOW(pattern[0]))
                            {
                                if (!GetFOLLOW(c).Contains(ch) && ch != '@')
                                {
                                    AddToFOLLOW(c,ch);
                                }
                            }
                        }
                        else
                        {
                            //not last
                            int nextIndex = currentIndex+1;
                            //terminal
                            if (IsTerminal(s[nextIndex]))
                            {
                                AddToFOLLOW(c, s[nextIndex]);
                                break;
                            }
                            else
                            {
                                //scan
                                while (nextIndex < s.Length)
                                {
                                    //is non terminal
                                    if (IsVariable(s[nextIndex]))
                                    {
                                        if (GetFIRST(s[nextIndex]).Contains('@'))
                                        {
                                            foreach (var ch in GetFIRST(s[nextIndex]))
                                            {
                                                if (!GetFOLLOW(c).Contains(ch) && ch != '@')
                                                {
                                                    AddToFOLLOW(c,ch);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            foreach (var ch in GetFIRST(s[nextIndex]))
                                            {
                                                if (!GetFOLLOW(c).Contains(ch))
                                                {
                                                    AddToFOLLOW(c,ch);
                                                }
                                            }
                                            break;
                                        }
                                    }
                                    //is terminal
                                    else
                                    {
                                        AddToFOLLOW(c,s[nextIndex]);
                                        break;
                                    }
                                    nextIndex++;
                                }
                                if (nextIndex == s.Length)
                                {
                                    foreach (var ch in GetFOLLOW(pattern[0]))
                                    {
                                        if (!GetFOLLOW(c).Contains(ch) && ch != '@')
                                        {
                                            AddToFOLLOW(c, ch);
                                        }
                                    }
                                }
                            }
                           
                        }
                        currentIndex = pattern.Substring(
                            currentIndex + 1, 
                            pattern.Length - currentIndex - 1).IndexOf(c);
                    }
                }
            }
        }
        public void BuildFOLLOWs()
        {
            this.GROUPS.Values.ToList().ForEach(g => g.FOLLOW.Clear());
            foreach (var c in GetDefinitions())
            {
                this.BuildFOLLOW(c);
            }
        }
    }
}
