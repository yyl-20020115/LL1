using System.Collections.Generic;

namespace Analysis
{
    public class Group
    {
        public char Variable { get; }
        public HashSet<char> FIRST { get; } = new HashSet<char>();
        public HashSet<char> FOLLOW { get; } = new HashSet<char>();
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

        public void AddToFIRST(char c)
        {
            FIRST.Add(c);
        }
        public void AddToFOLLOW(char c)
        {
            FOLLOW.Add(c);
        }
    }
}
