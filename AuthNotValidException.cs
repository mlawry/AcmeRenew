using System;
using System.Collections.Generic;
using System.Text;

namespace ACMErenew
{
    class AuthNotValidException : Exception
    {
        public AuthNotValidException(string msg) : base(msg)
        {
        }
    }
}
