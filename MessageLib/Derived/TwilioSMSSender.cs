using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageLib.Abstract;
using MessageLib.Exceptions;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;


namespace MessageLib.Derived
{
    public class TwilioSMSSender : SMSSender
    {
        /// <summary>
        /// Gets or sets the Twilio accountSid.
        /// </summary>
        public string? AccountSid { get; set; } = null;

        /// <summary>
        /// Gets or sets the Twilio authToken.
        /// </summary>
        public string? AuthToken { get; set; } = null;


        /// <summary>
        /// Initialises the Twilio client using the set AccountSid and AuthToken.
        /// </summary>
        public void Init()
        {
            if(this.AccountSid == null || this.AuthToken == null)
            {
                throw new CredentialsNotSetException("AccountSid or AuthToken not set.");
            }
            TwilioClient.Init(this.AccountSid, this.AuthToken);
        }

        /// <summary>
        /// Initialises the Twilio client using accountSid and authToken passed as parameters.
        /// </summary>
        /// <param name="accountSid">Twilio accountSid</param>
        /// <param name="authToken">Twilio authToken</param>
        public void Init(string accountSid, string authToken)
        {
            TwilioClient.Init(accountSid, authToken);
        }
        protected override void SendToSingleRecipient(string recipient)
        {
            var message = MessageResource.Create(
                body: this.Message,
                from: this.Sender,
                to: new Twilio.Types.PhoneNumber(recipient)
            );
        }
    }
}
