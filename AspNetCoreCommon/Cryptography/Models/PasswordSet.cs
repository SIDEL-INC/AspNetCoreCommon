using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCommon.Cryptography.Models
{
    public class PasswordSet
    {
        public string Password { get; set; }
        public string Salt { get; set; }
    }
}
