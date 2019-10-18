﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityGroupProject
{
    class Step10
    {
        /// <summary>
        /// Map every character to a different character using a mapping array.
        /// For example text = "acb" mapping = 'n', 'p', 'k' then the encrypted string = "nkp"
        /// </summary>
        /// <param name="text">The text to be mapped</param>
        /// <param name="mapping">The mapping array</param>
        /// <returns>The encoded string</returns>
        public static String Encrypt(String text, int[] mapping)
        {
            String encryptedText = "";
            foreach (Char c in text) {
//              Console.Write(c); Console.Write(":"); Console.Write(System.Convert.ToInt32(c)); Console.Write(",");
                encryptedText = encryptedText + System.Convert.ToChar(mapping[System.Convert.ToInt32(c)]);
            }
            return encryptedText;
        }
        /// <summary>
        /// Reverse the encryption applied in the Encrypt method in this class.
        /// </summary>
        /// <param name="text">The text to be decrypted</param>
        /// <param name="mapping">The mapping array</param>
        /// <returns>The decrypted string</returns>
        public static String Decrypt(String text, int[] mapping)
        {
            String decryptedText = "";
            foreach (Char c in text) {
                int val;
                val = System.Convert.ToInt32(c);
                int found;
                found = -1;
                for (int i = 0; i < mapping.Length; i++) {if (mapping[i] == val) { found = i; break; } }
                decryptedText = decryptedText + System.Convert.ToChar(found);
            }
            return decryptedText;
        }
    }
}
