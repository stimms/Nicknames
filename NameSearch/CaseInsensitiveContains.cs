using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameSearch
{
    internal static class CaseInsensitiveContainsExtension
    {
        public static bool CaseInsensitiveContains(this IEnumerable<String> source, string value)
        {
            foreach (String s in source)
            {
                if (s.ToUpper().Equals(value.ToUpper()))
                    return true;
            }
            return false;
        }
    }
}
