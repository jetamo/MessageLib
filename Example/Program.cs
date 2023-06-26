using MessageLib.Derived;


// Creating a TwilioSMSSender class instance.
TwilioSMSSender smsSender = new TwilioSMSSender();

// Setting the sid and authentication token from Twilio account.
smsSender.AccountSid = "accSid...";
smsSender.AuthToken = "authToken...";

// Initialising the Twilio client.
smsSender.Init();

// Setting the message to be sent to recipients.
smsSender.Message = "Sample msg";

// Setting a Twilio number of the sender.
smsSender.Sender = "+14179003250";

// Adding a recipient to the list of recipients.
smsSender.Recipients.Add("+420606403207");

// Sending the SMS to the recipients.
smsSender.Send();