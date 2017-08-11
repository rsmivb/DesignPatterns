using System;

namespace BridgePattern
{
    public class FancyFormmater : IFormatter
    {
        public string Format(string key, string value)
        {
            return $"{key}   |>-_=_=_-<|     {value}";
        }
    }
}