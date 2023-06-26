using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLib.Interfaces
{
    public interface IMessageSender
    {
        /// <summary>
        /// Gets or sets a list of recipients. Single recipients can be added by List.Add() method.
        /// </summary>
        public List<string> Recipients { get; set; }

        /// <summary>
        /// Gets or sets the sender.
        /// </summary>
        public string? Sender { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string? Message { get; set; }

        /// <summary>
        /// Sends the set message to recipients.
        /// </summary>
        public void Send();
        /// <summary>
        /// Sets the message passed as a parameter and sends it to recipients.
        /// </summary>
        /// <param name="message">Message to be sent.</param>
        public void Send(string message);
    }
}
