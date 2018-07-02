using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RedditDailyCoding.Solutions.Day7.Easy
{
    class MorseCodeTree
    {
        public char val;
        public MorseCodeTree dat = null;
        public MorseCodeTree dit = null;

        public MorseCodeTree(char[] value, int index)
        {
            val = value[index];

            if (index * 2 + 1 < value.Length)
                dat = new MorseCodeTree(value, index * 2 + 1);

            if (index * 2 + 2 < value.Length)
                dit = new MorseCodeTree(value, index * 2 + 2);
        }

        public char DatDit(char[] pat, int index)
        {

            // End of the line "?"
            if (val == '?')
                return '?';

            if (index == pat.Length)
                return val;

            if (pat[index] == '-')
            {
                if (dat == null)
                    return '?';
                return dat.DatDit(pat, index + 1);
            }

            if (pat[index] == '.')
            {
                if (dit == null)
                    return '?';
                return dit.DatDit(pat, index + 1);
            }

            if (pat.Contains('/'))
                return ' ';

            return '?';

        }

    }
}
