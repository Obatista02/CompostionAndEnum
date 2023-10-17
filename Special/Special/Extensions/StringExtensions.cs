

namespace System
{
    static class StringExtensions
    {
        public static string Cut(this string ThisObj, int count) 
        {
            if (ThisObj.Length <= count)
            {
                return ThisObj;
            }
            else
            {
                return ThisObj.Substring(0, count)  + "...";
            }
        }

    }
}
