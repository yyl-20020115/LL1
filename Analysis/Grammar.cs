using System.Collections.Generic;

namespace Analysis
{
    public class Grammar
    {
        public List<string> Productions { get; } = new List<string>();

        public void ParseAndAddProduction(string production)
        {
            var part_count = 0;
            for (var i = 0; i < production.Length; i++)
            {
                if (production[i] == '|')
                {
                    part_count++;
                }
            }
            if (part_count > 0)
            {
                var start = 3;
                var m = 0;
                var amount = production.Length;
                var text = production.Substring(0, 3);
                for (m = start; m < amount; m++)
                {
                    if (production[m] == '|')
                    {
                        var str = production.Substring(start, m - start);
                        this.Productions.Add(text + str);
                        start = m + 1;
                    }
                }
                this.Productions.Add(text + production.Substring(start, m - start));
            }
            else
            {
                this.Productions.Add(production);
            }
        }
    }
}
