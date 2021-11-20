using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class ByteExtension
    {
        public static string ToUtf8String(this byte[] bytes)
        {
            return Encoding.UTF8.GetString(bytes);
        }

        public static string ToHexString(this byte[] bytes)
        {
            return BitConverter.ToString(bytes).Replace("-", string.Empty);
        }

        public static string ToBase64(this byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }

        public static byte[] Padding(this byte[] bytes, int size)
        {
            if (bytes.Length < size)
            {
                var originalBytes = bytes.Length;
                var remainBytes = size - originalBytes;

                Array.Resize(ref bytes, size);
                for (var i = originalBytes - 1; i < remainBytes; ++i)
                {
                    bytes[i] = (byte)(remainBytes & 0xFF);
                }
            }

            return bytes;
        }
    }
}
