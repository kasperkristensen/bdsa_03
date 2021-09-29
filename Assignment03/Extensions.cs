using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace  Assignment03
{
    public static class Extensions {

        public static IEnumerable<int> Flatten(this IEnumerable<int>[] xs) {
            foreach (var e in xs)
            {
                foreach (var item in e)
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<int> Filter(this int[] ys) {
            foreach (var item in ys)
            {
                if (item > 42 && item % 7 == 0) {
                    yield return item;
                }
            }
        }

        public static IEnumerable<int> IsLeapYear(this int[] ys) {
            foreach (var year in ys)
            {
                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) {
                    yield return year;
                }
            }
        }

        public static bool IsSecure(this Uri uri) {
            return uri.Scheme == Uri.UriSchemeHttps;
        }

        //[a-zA-Z]+
        public static int WordCount(this string str) {
            var regex = new Regex(@"(\s+|^)[a-zA-Z]+(?=\s+|$)");
            var match = regex.Match(str);

            var count = 0;
            
            for (; match.Success ; match = match.NextMatch()) {
                count++;
            }

            return count;
        }

    }
}