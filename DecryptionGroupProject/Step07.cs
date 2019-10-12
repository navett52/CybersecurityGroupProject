﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityGroupProject
{
    class Step07
    {
            /// <summary>
            /// Encrypt the String
            /// </summary>
            /// <param name="text">String to be encrypted. From the left, add 1, then 2, then 3 to each character up to 100 inclusive,
            /// then start from 1 again</param>
            /// <returns>Encrypted String</returns>
            public static String Encrypt(String text)
            {
                String encryptedText = "";
            int increment = 1;
            for (int i = 0; i < text.Length; i++) {
                    encryptedText += (Char)(((int)text.ToCharArray()[i]) + increment);
                    increment++;
                    if (increment == 101) { increment = 1; }
            }
            return encryptedText;
            }
        /// <summary>
        /// Decrypt the String
        /// </summary>
        /// <param name="text">String to be decrypted. From the left, subtract 1, then 2, then 3 to each character up to 100 inclusive,
        /// then start again from 1</param>
        /// <returns>Decrypted String</returns>
        public static String Decrypt(String text) {
            String decryptedText = "";
            int increment = 1;
            for (int i = 0; i < text.Length; i++)
            {
                decryptedText += (Char)(((int)text.ToCharArray()[i]) - increment);
                increment++;
                if (increment == 101) { increment = 1; }
            }
            return decryptedText;
        }
    }
}

