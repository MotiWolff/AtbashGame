using System;
using System.Collections.Generic;


public class AtbashDecrypter
{
    private static Dictionary<char, char> azcy = new Dictionary<char, char>();

    //dict thet hold a-z b-y cipher
    static AtbashDecrypter()
    {
        for(char c = 'A'; c <= 'Z'; c++) azcy[c] = (char)('Z' - (c - 'A'));
        for(char c = 'a'; c <= 'z'; c++) azcy[c] = (char)('z' -  (c - 'a'));
    }

    // Decrypt the data if data use a-z b-y cipher
    public static string Decrypt(string[] input)
    {
        string[] decrypted = new string[string.Length];

        for(int i = 0;i < input.Length;i++)
        {
            string in = "";
            foreach(char c in input)
            {
                input += azcy.ContainsKey(c) ? azcy[c] : c;
            }
            decrypted[i] = in;
        }
        return decrypted;
    }




}
