using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringBuilderSubstring
{
    public static class Extensions
    {
        public static StringBuilder SubstringStringBuilder(this StringBuilder sb, int index, int length)
        {
            StringBuilder result = new StringBuilder();
            if (index < 0 || index >= sb.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (length < 0 || length >= sb.Length - index)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            for (int i = index; i < index+length; i++)
            {
                result.Append(sb[i]);
            }
            return result;
        }
    }
}
