using System.Linq;

namespace RedditDailyCoding.Solutions.Day7.Easy
{
    class MorseCodeTree
    {
        public char val;
        public MorseCodeTree dat = null;
        public MorseCodeTree dit = null;

        // Constructor, takes in a flat tree string
        public MorseCodeTree(char[] value, int index)
        {
            val = value[index];

            if (index * 2 + 1 < value.Length)
                dat = new MorseCodeTree(value, index * 2 + 1);

            if (index * 2 + 2 < value.Length)
                dit = new MorseCodeTree(value, index * 2 + 2);
        }

        public char treeCrawler(char[] morseString, int index)
        {

            // If we ever reach a ? node, we inputed some faulty morse code and return ? (no correct path goes through a ?, due to how morse is encoded)
            if (val == '?')
                return '?';

            // If index is the size of the string, we've reached destination, and return val
            if (index == morseString.Length)
                return val;

            // Check if current index of string is a dat or a dit, recursively crawls the tree
            if (morseString[index] == '-')
            {
                if (dat == null)
                    return '?';
                return dat.treeCrawler(morseString, index + 1);
            }

            if (morseString[index] == '.')
            {
                if (dit == null)
                    return '?';
                return dit.treeCrawler(morseString, index + 1);
            }

            if (morseString.Contains('/'))
                return ' ';

            return '?';

        }

    }
}
