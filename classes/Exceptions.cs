using System;

namespace Nika_Iakobashvili_Davaleba_9.classes
{
    internal class InvalidName : Exception
    {
        public InvalidName(string message) : base(message)
        {
        }

    }
    class InvalidId : Exception
    {
        public InvalidId(string message) : base(message)
        {
        }
    }
    class InvalidBirthDate : Exception
    {
        public InvalidBirthDate(string message) : base(message)
        {
        }
    }
    class InvalidEmail : Exception
    {
        public InvalidEmail(string message) : base(message)
        {
        }
    }
    class InvalidPhone : Exception
    {
        public InvalidPhone(string message) : base(message)
        {
        }
    }
    class InvalidPostalCode : Exception
    {
        public InvalidPostalCode(string message) : base(message)
        {
        }
    }
    class InvalidWebAddress : Exception
    {
        public InvalidWebAddress(string message) : base(message)
        {
        }
    }


}
