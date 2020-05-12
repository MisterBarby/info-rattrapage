using System;
using System.Collections.Generic;

namespace Cryptanalysis
{
public static class Tools
{
    public static int Modulus(int a, int b)
    {
        if (b < 0)
            b = -b;
        
        var mod = a % b;
        return mod < 0 ? b + mod : mod;
    }

    public static int LetterIndex(char c)
    {
        int Index = 0;
        int charInt = Convert.ToInt32(c);
        if (charInt < 65 || (charInt > 90 && charInt < 97) || charInt > 122)
        {
            Index = -1;
        }
        else if (charInt < 91 && charInt > 64)
        {
            Index = charInt - 65;
        }
        else if (charInt < 123 && charInt > 96)
        {
            Index = charInt - 97;
        }

        return Index;
    }
    
    public static char RotChar(char c, int n)
    {
        int i = LetterIndex(c);
        char endChar = 'a';
        if (i == -1)
        {
            endChar = c;
        }
        else if (Convert.ToInt32(c) < 92)
        {
            endChar = Convert.ToChar(65 + Modulus((Convert.ToInt32(c) - 65) + n, 26));
        }
        else
        {
            endChar = Convert.ToChar(97 + Modulus((Convert.ToInt32(c) - 97) + n, 26));
        }

        return endChar;

    }

    public static int[] Histogram(string str)
    {
        int[] histo = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        int i = 0;
        while (i < str.Length)
        {
            int index = LetterIndex(str[i]);
            histo[index] += 1;
        }

        return histo;
    }
    
    public static string FilterLetters(string str)
    {
        throw new NotImplementedException();
    }

    public static string Extract(string str, int start, int step)
    {
        throw new NotImplementedException();
    }
}
}
