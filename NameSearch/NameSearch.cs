using System;
using System.Collections.Generic;
using System.Linq;

namespace NameSearch
{
	public class NameSearch
	{
		public static List<String> GetOtherFormsOfNames(String nameToCheck)
		{
            List<string> returnValue = new List<string>();
            foreach(var nameset in Names.names.Where(b => b.Any(c=>c.Equals(nameToCheck, StringComparison.InvariantCultureIgnoreCase ))))
            {
                returnValue.AddRange(nameset);
            }
            return returnValue;
		}

        public static bool AreTheSameName(string baseName, string nameToCheck)
        {
            if (GetOtherFormsOfNames(baseName).Any(x=>x.Equals(nameToCheck, StringComparison.InvariantCultureIgnoreCase)))
                return true;
            return false;
        }
	}
}

