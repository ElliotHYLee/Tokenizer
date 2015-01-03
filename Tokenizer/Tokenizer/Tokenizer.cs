﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tokenizer
{
    static class Tokenizer
    {
        public static string trim(string x)
        {
            int beginPos = findFirstChar(x, '[', true);
            int endPos = findFirstChar(x, ']', false);
            string result = x.Substring(beginPos, endPos - beginPos +1);
            return result;
        }

        private static int findFirstChar(string str, char x, bool fromFront)
        {
            int result = 0;
            if (fromFront)
            {
                result = str.IndexOf(x.ToString());
            }
            else
            {
                string revStr = reverse(str);
                int position = revStr.IndexOf(x.ToString()) + 1;
                result = str.Length - position;
            }
            return result;
        }

        private static string reverse(string str)
        {
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }

        public static List<string> getTokens(string str)
        {
            List<string> result = new List<string>();
            int beginPos = findFirstChar(str, '[', true);
            int endPos = findFirstChar(str, ']', true);
            string temp = null;
            while (str.Length > 0)
            {
                // get first token of the string
                temp = str.Substring(beginPos + 1, endPos - beginPos-1);
                result.Add(temp);
                // prepare the next string
                str = str.Substring(endPos + 1, str.Length - endPos - 1);
                beginPos = findFirstChar(str, '[', true);
                endPos = findFirstChar(str, ']', true);
            }
            return result;
        }

    }
}
