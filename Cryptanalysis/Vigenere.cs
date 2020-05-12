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
            
        }
        return KeyEnd;
    }
    
    public string Encrypt(string msg)
    {
        int i = 0;
        while (i < msg.Length)
        {
            int j = 0;
            while (j < Key.Length )
            {
                
            }
        }

        return "ee";
    }

    public string Decrypt(string cypherText)
    {
        throw new NotImplementedException();
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
