using System;
using System.Linq;

namespace BridgePattern
{
    internal class ReverseFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return $"{key} <-> {value}".ToCharArray().Reverse().ToString();
        }
    }
}