using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Analysis
{
    public class TableRow
    {
        public string Pattern { get; } = string.Empty;
        public List<char> Terminals { get; } = new List<char>();
        public TableRow(string pattern, List<char> terminals)
        {
            this.Pattern = pattern;
            this.Terminals = terminals;
        }
    }
}
