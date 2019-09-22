using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Analysis
{
    public class Group
    {
        public char Variable { get; }
        public List<char> FIRST { get; } = new List<char>();
        public List<char> FOLLOW { get; } = new List<char>();
        public Group(char variable, char c,bool first_or_follow = true)
        {
            this.Variable = variable;
            if (first_or_follow)
            {
                this.FIRST.Add(c);
            }
            else
            {
                this.FOLLOW.Add(c);
            }
        }

        public void AddFirst(char c)
        {
            FIRST.Add(c);
        }
        public void AddFollow(char c)
        {
            FOLLOW.Add(c);
        }
    }
}
