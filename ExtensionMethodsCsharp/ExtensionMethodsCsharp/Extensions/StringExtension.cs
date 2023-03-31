using System;
using System.Globalization;

namespace ExtensionMethodsCsharp.Extensions
{
    static class StringExtension
    {
        public static String Cut(this String thisObj, int count)
        {
            if (thisObj.Length <= count)
            {
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0, count) + "...";
            }
        }
    }
}
