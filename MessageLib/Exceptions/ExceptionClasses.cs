using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLib.Exceptions
{
    [Serializable]
    public class CredentialsNotSetException : Exception
    {
        public CredentialsNotSetException() { }

        public CredentialsNotSetException(string message)
            : base(message) { }

        public CredentialsNotSetException(string message, Exception inner)
            : base(message, inner) { }
    }

    [Serializable]
    public class SenderNotSetException : Exception
    {
        public SenderNotSetException() { }

        public SenderNotSetException(string message)
            : base(message) { }

        public SenderNotSetException(string message, Exception inner)
            : base(message, inner) { }
    }

    [Serializable]
    public class NoRecipientSetException : Exception
    {
        public NoRecipientSetException() { }

        public NoRecipientSetException(string message)
            : base(message) { }

        public NoRecipientSetException(string message, Exception inner)
            : base(message, inner) { }
    }

    [Serializable]
    public class NoMessageSetException : Exception
    {
        public NoMessageSetException() { }

        public NoMessageSetException(string message)
            : base(message) { }

        public NoMessageSetException(string message, Exception inner)
            : base(message, inner) { }
    }
}
