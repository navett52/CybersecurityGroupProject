﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityGroupProject
{
    class Step06
    {
        /// <summary>
        /// Encrypt the String
        /// </summary>
        /// <param name="text">String to be encrypted. Swap every other character</param>
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
        /// Decrypt the String
        /// </summary>
        /// <param name="text">String to be decrypted. Swap every other character</param>
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