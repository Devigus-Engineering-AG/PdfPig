﻿namespace UglyToad.PdfPig.Core
{
    using System;
    using System.Text;

    /// <summary>
    /// Convenience access to frequently used encodings.
    /// </summary>
    public static class OtherEncodings
    {
        /// <summary>
        /// Latin 1 Encoding: ISO 8859-1 is a single-byte encoding that can represent the first 256 Unicode characters.
        /// </summary>
        public static readonly Encoding Iso88591 = Encoding.GetEncoding("ISO-8859-1");

        /// <summary>
        /// Convert the string to bytes using the ISO 8859-1 encoding.
        /// </summary>
        public static byte[]? StringAsLatin1Bytes(string? s)
        {
            if (s == null)
            {
                return null;
            }

            return Iso88591.GetBytes(s);
        }

        /// <summary>
        /// Convert the bytes to string using the ISO 8859-1 encoding.
        /// </summary>
        public static string BytesAsLatin1String(ReadOnlySpan<byte> bytes)
        {
            return Iso88591.GetString(bytes);
        }
    }
}
