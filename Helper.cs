using System;
using System.Collections.Generic;

namespace TestTime 
{
    public static class Helper 
    {
        public static string Log(this SystemTime time)        
        {
            return  $"ST: {time.Day}-{time.Month}-{time.Year} {time.Hour:d2}:{time.Minute:d2}";
        }

    

    public static string Escape(this string source)
        {
            if (String.IsNullOrEmpty(source)) return String.Empty;

            char[] data = source.ToCharArray();
            List<char> res = new List<char>();
            for (int i = 0; i < data.Length; i++)
                if (Char.IsLetterOrDigit(data[i]) || data[i] == ' ' || data[i] == '-' || data[i] == '.' || data[i] == '(' || data[i] == ')')
                    res.Add(data[i]);
            return new string(res.ToArray());
        }
    }
}