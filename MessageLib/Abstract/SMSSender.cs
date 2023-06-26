using MessageLib.Interfaces;
using MessageLib.Exceptions;

namespace MessageLib.Abstract
{
    public abstract class SMSSender : IMessageSender
    {
        public virtual List<string> Recipients { get; set; } = new List<string>();
        public string? Sender { get; set; } = null;
        public string? Message { get; set; } = null;

        /// <summary>
        /// Sends the set message to a single recipient.
        /// </summary>
        /// <param name="recipient">Recipient's phone number.</param>
        protected abstract void SendToSingleRecipient(string recipient);

        public virtual void Send()
        {
            if(this.Message == null)
            {
                throw new NoMessageSetException();
            }
            if(this.Sender == null)
            {
                throw new SenderNotSetException();
            }
            if(this.Recipients.Count < 1)
            {
                throw new NoRecipientSetException();
            }
            foreach(string recipient in this.Recipients)
            {
                this.SendToSingleRecipient(recipient);
            }
        }
        public virtual void Send(string message)
        {
            this.Message = message;
            this.Send();
        }
    }
}
