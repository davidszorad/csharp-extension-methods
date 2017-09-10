using System;
using System.Linq;

namespace System
{
    // All our extensions should be in this class
    // Extension class has to be public and static and all it's methods should be public static as well
    // Naming convention is to start with the name of class we are extending and postfixing it with Extensions
    // this String str => represents the actual instance we are applying the method on
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("Number of words should be positive number.");

            if (numberOfWords == 0)
                return string.Empty;

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords)) + "...";
        }
    }
}
