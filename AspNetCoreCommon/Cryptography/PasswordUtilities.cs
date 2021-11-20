using AspNetCoreCommon.Cryptography.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace AspNetCoreCommon.Cryptography
{
    public static class PasswordUtilities
    {
        public static PasswordSet Generate(string plaintext, string salt = null)
        {
            byte[] saltBytes = salt?.AsBase64Bytes() ?? RandomUtilities.Bytes(32);
            Rfc2898DeriveBytes generator = new(plaintext, saltBytes, 1024, HashAlgorithmName.SHA256);

            return new()
            {
                Password = generator.GetBytes(32).ToBase64(),
                Salt = saltBytes.ToBase64()
            };
        }
    }
}
