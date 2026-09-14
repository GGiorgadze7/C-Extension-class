using System;
using System.Collections.Generic;
using System.Text;

namespace C___Extension_class.Models
{
    public static class StringExtensions
    {
        public static bool IsPalindrom(this string str)
        {
            string lowerstr = str.ToLower();

            string reversstr = "";

            for (int i = lowerstr.Length - 1; i >= 0; i--)
            {
                reversstr = reversstr + lowerstr[i];

            }

            if (reversstr == lowerstr)
            {
                return true;
            }
            else
            {
                return false;
            }



        }



        public static int WordCount(this string str)
        {
            string[] word = str.Split(' ');

            return word.Length;

        }



        public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T> source)
        {
            List<T> result = new List<T>();

            foreach (T item in source)
            {
                if (item != null)
                {
                    result.Add(item);
                }
            }

            return result;
        }


        public static string ToFriendlyDate(this DateTime date)
        {
            DateTime today = DateTime.Now.Date;

            DateTime dateOnly = date.Date;
            if (dateOnly == today)
            {
                return "dges";
            }
            else if (dateOnly == today.AddDays(-1))
            {
                return "gushin";
            }
            else if (dateOnly == today.AddDays(1))
            {
                return "xval";
            }
            else
            {
                return date.ToString("dd MMMM, yyyy");
            }



        }



        public static bool IsInRange(this int number, int min, int max)
        {
            if (number >= min && number <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static void ReverseList<T>(this List<T> list)
        {
            List<T> tempList = new List<T>();

            for (int i = list.Count - 1; i >= 0; i--)
            {
                tempList.Add(list[i]);
            }

            list.Clear();

            for (int i = 0; i < tempList.Count; i++)
            {
                list.Add(tempList[i]);
            }
        }



    }
}
