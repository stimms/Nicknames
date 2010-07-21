using System;
using System.Collections.Generic;
using System.Linq;

namespace NameSearch
{
	public class NameSearch
	{
		public static List<String> GetSimilarNames(String nameToCheck)
		{
            List<string> returnValue = new List<string>();
            foreach(String[] nameset in Names.names.Where(b => b.CaseInsensitiveContains(nameToCheck)))
            {
                returnValue.AddRange(nameset);
            }
            return returnValue;
		}

        public static bool AreTheSameName(string baseName, string nameToCheck)
        {
            if (GetSimilarNames(baseName).CaseInsensitiveContains(nameToCheck))
                return true;
            return false;
        }
	}
}

