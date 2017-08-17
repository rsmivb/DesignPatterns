using System;
using System.Linq;

namespace BridgePattern
{
    internal class ReverseFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            char[] format = $"{key} <-> {value}".ToCharArray();
            Array.Reverse(format);
            return new string(format);
        }
    }
}