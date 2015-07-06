// <copyright file="StringExtensions.cs" company="Telerik Academy">
//     Copyright (c) Telerik Academy. All rights reserved.
// </copyright>
namespace StringExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Static class providing various string extension methods: 
    /// <list type="bullet">
    /// <item> 
    /// <description>ToMd5Hash,</description> 
    /// </item> 
    /// <item> 
    /// <description>ToBoolean,</description> 
    /// </item>
    /// <item> 
    /// <description>ToShort,</description> 
    /// </item> 
    /// <item> 
    /// <description>ToInteger,</description> 
    /// </item>
    /// <item> 
    /// <description>ToLong,</description> 
    /// </item>
    /// <item> 
    /// <description>ToDateTime,</description> 
    /// </item>
    /// <item> 
    /// <description>CapitalizeFirstLetter,</description> 
    /// </item>
    /// <item>
    /// <description>ConvertCyrillicToLatinLetters,</description>
    /// </item>
    /// <item>
    /// <description>ConvertLatinToCyrillicKeyboard,</description>
    /// </item>
    /// <item>
    /// <description>ToValidUsername,</description>
    /// </item>
    /// <item>
    /// <description>ToValidLatinFileName,</description>
    /// </item>
    /// <item>
    /// <description>GetFirstCharacters,</description>
    /// </item>
    /// <item>
    /// <description>GetFileExtension,</description>
    /// </item>
    /// <item>
    /// <description>ToContentType,</description>
    /// </item>
    /// <item>
    /// <description>ToByteArray,</description>
    /// </item>
    /// </list> 
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Encodes a string to byte array, computes the hash and formats each one as a hexadecimal string.
        /// </summary>
        /// <param name="input">A string.</param>
        /// <returns>The string as hexadecimal string.</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and computes the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }

        /// <summary>
        ///  A string extension method that checks whether the target string is contained within a 
        /// predefined collection of true-like values.
        /// </summary>
        /// <param name="input">A true-like or false-like statement(ex. 1,0,yes).</param>
        /// <returns>True or false.</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Parses a string to short value type.
        /// </summary>
        /// <param name="input">A string.</param>
        /// <returns>Short value or null.</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Parses a string to integer value type.
        /// </summary>
        /// <param name="input">A string.</param>
        /// <returns>Integer value or null.</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Parses a string to long value type.
        /// </summary>
        /// <param name="input">A string.</param>
        /// <returns>Long value or null.</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Parses a string to DateTime value type.
        /// </summary>
        /// <param name="input">A string.</param>
        /// <returns>DateTime value or null.</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Capitalizes the first letter of a string.
        /// </summary>
        /// <param name="input">A string.</param>
        /// <returns>The string with first letter capitalized.</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Delivers the string in between two other strings contained in an initial string.
        /// </summary>
        /// <param name="input">A string to be searched.</param>
        /// <param name="startString">A string from where to start.</param>
        /// <param name="endString">A string where to finish.</param>
        /// <param name="startFrom">An integer to search from a starting point in the input.</param>
        /// <returns>A string starting from the index of startString in input and ending at the index of endString in the input.</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Parses Cyrillic letters to Latin letters.
        /// </summary>
        /// <param name="input">A string containing Cyrillic letters.</param>
        /// <returns>The initial string with replaced Cyrillic with Latin letters.</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Parses Latin letters to Cyrillic letters.
        /// </summary>
        /// <param name="input">A string containing Latin letters.</param>
        /// <returns>The initial string with replaced Latin with Cyrillic letters.</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Removes any unnecessary characters for a username in given string.
        /// </summary>
        /// <param name="input">A username string.</param>
        /// <returns>A valid Latin username.</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Removes any unnecessary characters for a filename in given string.
        /// </summary>
        /// <param name="input">A filename string.</param>
        /// <returns>A valid Latin filename.</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Extracts a number of characters in a string, starting from the beginning.
        /// </summary>
        /// <param name="input">A string.</param>
        /// <param name="charsCount">The number of characters to be extracted.</param>
        /// <returns>A number of characters starting from the beginning.</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Finds the file extension off a given valid filename.
        /// </summary>
        /// <param name="fileName">A file name in a string format.</param>
        /// <returns>The name of the file extension in string format.</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Finds the content type according to the file extension.
        /// </summary>
        /// <param name="fileExtension">The file extension in a string format.</param>
        /// <returns>Content type or "application/octet-stream".</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Converts a string to byte array.
        /// </summary>
        /// <param name="input">A string.</param>
        /// <returns>An array of bytes.</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
