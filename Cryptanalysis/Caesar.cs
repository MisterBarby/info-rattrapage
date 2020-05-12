using System;

namespace Cryptanalysis
{
    public class Caesar
    {

        private int Key;


        public Caesar(int key)
        {
            Key = key;

        }

        public string Encrypt(string msg)
        {
            int i = 0;
            string endStr = "";
            while (i < msg.Length)
            {
                if (Tools.LetterIndex(msg[i]) == -1)
                {

                }
                else
                {
                    endStr += Tools.RotChar(msg[i], Key);
                }

                i += 1;
            }

            return endStr;
        }

        public string Decrypt(string cypherText)
        {
            int i = 0;
            string endStr = "";
            while (i < cypherText.Length)
            {
                if (Tools.LetterIndex(cypherText[i]) == -1)
                {

                }
                else
                {
                    endStr += Tools.RotChar(cypherText[i], -Key);
                }
                i += 1;
            }

            return endStr;
        }

        public static int GuessKey(string cypherText)
        {
            int[] histo = Tools.Histogram(cypherText);
            int i = 0;
            int index = 0;
            int max = 0;
            while (i < histo.Length)
            {
                if (histo[i] > max)
                {
                    index = i;
                    max = histo[i];
                }

                i += 1;
            }

            int key = Tools.Modulus(index - 4, 26);
            return key;
        }
    }
}