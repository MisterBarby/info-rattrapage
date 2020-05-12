using System;
using System.Collections.Generic;
using System.Data;

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
            i += 1;
        }

        return histo;
    }
    
    public static string FilterLetters(string str)
    {
        string strEnd = "";
        int i = 0;
        while (i < str.Length)
        {
            if (LetterIndex(str[i]) == -1)
            {
                
            }
            else
            {
                strEnd += str[i];
            }

            i += 1;
        }
        return strEnd;
    }

    public static string Extract(string str, int start, int step)
    {
        if (step < 1)
        {
            throw new DataException("step must be superior to 0");
        }

        string strStart = "";
        int i = start - 1;
        int indexStep = 1;
        string strEnd = "";
        while (i < str.Length)
        {
            strStart += str[i];
            i += 1;
        }

        i = start - 1;
        while (i < str.Length - start)
        {
            if (indexStep > step)
            {
                indexStep = 1;
            }

            if (indexStep == 1)
            {
                strEnd += strStart[i];
            }

            i += 1;
            indexStep += 1;
        }

        return strEnd;
    }
}
}
