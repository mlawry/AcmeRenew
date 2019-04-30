using System;

namespace AcmeRenew
{
    class AuthNotValidException : Exception
    {
        public AuthNotValidException(string msg) : base(msg)
        {
        }
    }
}
