using System;
using System.Collections.Generic;
using System.Linq;

namespace Utilities
{
    public static class EnumConversion
    {
        public static Dictionary<int, string> EnumToDictionary<T>() where T : Enum
        {
            IEnumerable<T> values = Enum.GetValues(typeof(T)).Cast<T>();
            Dictionary<int, string> dictionary = values.ToDictionary(e => Convert.ToInt32(e), e => e.ToString());
            return dictionary;
        }
        
        public static KeyValuePair<int,string>[] EnumToArray<T>() where T : Enum
        {
            return EnumToDictionary<T>().ToArray();
        }
    }
}