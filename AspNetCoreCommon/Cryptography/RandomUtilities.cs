using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace AspNetCoreCommon.Cryptography
{
    public static class RandomUtilities
    {
        public static byte[] Bytes(long length)
        {
            var rng   = RandomNumberGenerator.Create();
            var bytes = new byte[length];

            rng.GetBytes(bytes);
            
            return bytes;
        }

        public static int Int32()
        {
            var bytes = Bytes(4);
            return BitConverter.ToInt32(bytes);
        }

        public static short Int16()
        {
            var bytes = Bytes(2);
            return BitConverter.ToInt16(bytes);
        }
    }
}
