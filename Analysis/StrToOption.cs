using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Analysis
{
    class StrToOption
    {
        public static string getOption(string str)
        {
            string s = "";
            string[] strSpilite = str.Split(' ');
            for (int i = 0; i < strSpilite.Length; i++)
            {
                MessageBox.Show(strSpilite[i]);
                if (IsNum(strSpilite[i]))
                {
                    s += "i";
                }
                else if (strSpilite[i] == "int")
                {
                    s += "a";
                }
                else
                {
                    s += s;
                }
            }
            return s;
        }
        public static bool IsNum(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsNumber(str, i))
                    return false;
            }
            return true;
        }

    }
}
