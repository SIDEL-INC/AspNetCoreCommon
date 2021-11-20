using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class StringExtensions
    {
        public static byte[] AsUtf8(this string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }

        public static byte[] AsBase64Bytes(this string str)
        {
            return Convert.FromBase64String(str);
        }

        public static string Hash(this string str)
        {
            return str.AsUtf8().ToHexString();
        }
    }
}
