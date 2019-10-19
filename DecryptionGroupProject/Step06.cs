﻿/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;

namespace CyberSecurityGroupProject
{
    class Step06
    {
        /// <summary>
        /// Encrypt the String
        /// Swap every other character. 
        /// If the number of chars in text is odd, do not change the last character</param>
        /// For example "abcd" = "badc".
        /// </summary>
        /// <param name="text">String to be encrypted.  Characters in text must be from 1 to 127, inclusive. 
        /// <returns>Encrypted String</returns>
        public static String Encrypt(String text)
        {
            String encryptedText = "";
            try {
                for (int i = 0; i < text.Length; i += 2) {
                    encryptedText += text.Substring(i+1, 1);
                    encryptedText += text.Substring(i, 1);
                }
            } catch (Exception ex) {
                // If we end up here the string has an odd number of chars in it. 
                encryptedText += text.Substring(text.Length - 1, 1);
            }
            return encryptedText;
        }
        /// <summary>
        /// Reverse the encryption applied in the Encrypt method in this class.
        /// </summary>
        /// <param name="text">String to be decrypted. Swap every other character to reverse the Encrypt method above</param>
        /// <returns>Decrypted String</returns>
        public static String Decrypt(String text)
        {
            String decryptedText = "";
            try {
                for (int i = 0; i < text.Length; i += 2)
                {
                    decryptedText += text.Substring(i + 1, 1);
                    decryptedText += text.Substring(i, 1);
                }
            } catch (Exception ex) {
                // If we end up here the string has an odd number of chars in it. 
                decryptedText += text.Substring(text.Length - 1, 1);
            }
            return decryptedText;
        }
    }
}
