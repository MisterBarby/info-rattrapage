using System;

namespace Cryptanalysis
{
public class Vigenere
{
    public const float FrenchIndexOfCoincidence = 0.0778F;
    
    private string Key;
    
    public Vigenere(string key)
    {
        Key = key;
    }

    public string _CleanKey(string key)
    {
        string KeyEnd = "";
        int i = 0;
        while (i < Key.Length)
        {
            if (Tools.LetterIndex(Key[i]) == -1)
            {
                
            }
            else
            {
                KeyEnd += Key[i];
            }

            i += 1;
        }
        return KeyEnd;
    }
    
    public string Encrypt(string msg)
    {
        string usedKey = _CleanKey(Key);
        int i = 0;
        int j = 0;
        string crypted = "";
        while (i < msg.Length)
        {
            if (j == usedKey.Length)
            {
                j = 0;
            }
            
            if (Tools.LetterIndex(msg[i]) == -1)
            {
                crypted += msg[i];
            }
            else
            {
                crypted += Tools.RotChar(msg[i], Tools.LetterIndex(usedKey[j]));
                j += 1;
            }

            i += 1;
        }

        return crypted;
    }

    public string Decrypt(string cypherText)
    {
        string usedKey = _CleanKey(Key);
        int i = 0;
        int j = 0;
        string crypted = "";
        while (i < cypherText.Length)
        {
            if (j == usedKey.Length)
            {
                j = 0;
            }
            
            if (Tools.LetterIndex(cypherText[i]) == -1)
            {
                crypted += cypherText[i];
            }
            else
            {
                crypted += Tools.RotChar(cypherText[i], -Tools.LetterIndex(usedKey[j]));
                j += 1;
            }

            i += 1;
        }

        return crypted;
    }

    public static string GuessKeyWithLength(string cypherText, int keyLength)
    {
        throw new NotImplementedException();
    }
    
    public static float IndexOfCoincidence(string str)
    {
        throw new NotImplementedException();
    }

    public static int GuessKeyLength(string cypherText)
    {
        throw new NotImplementedException();
    }
    
    public static string GuessKey(string cypherText)
    {
        throw new NotImplementedException();
    }
}
}
