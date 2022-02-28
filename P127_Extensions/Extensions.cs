using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Extensions
{
    static class Extensions
    {
        public static bool isCapitalized(this string word)
        {
            if (char.IsUpper(word[0]))
            {
                for (int i = 1; i < word.Length; i++)
                {
                    if (!char.IsLower(word[i]))
                    {
                        return false;
                    }
                 
                }
                return true;
            }
            return false;
        }

        public static bool Passed(this Student stu)
        {
            if (stu.Point < 50)
            {
                return false;
            }
            return true;
        }


        public static string ToCapitalized(this string word)
        {
            word = word.ToLower();


            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(char.ToUpper(word[0]).ToString());

            for (int i = 1; i < word.Length; i++)
            {
                stringBuilder.Append(word[i]);
            }

            return stringBuilder.ToString();

        }
    }
}
