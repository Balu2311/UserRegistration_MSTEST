using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration__Exceptions
{
    public class UserRegistrationCustomException : Exception
    {
        private readonly ExceptionType type;

        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE,
            INVALID_INPUT
        }


        public UserRegistrationCustomException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }

    }
}
