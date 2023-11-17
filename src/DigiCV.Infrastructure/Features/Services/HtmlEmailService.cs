﻿using DigiCV.Domain.Services;
using DigiCV.Domain.Utilities;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;


namespace DigiCV.Infrastructure.Features.Services
{
    public class HtmlEmailService : IEmailService
    {
        private readonly Smtp _emailSettings;

        public HtmlEmailService(IOptions<Smtp> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public void SendSingleEmail(string receiverName, string receiverEmail,
            string subject, string body)
        {
            var message = new MimeMessage();

            message.From.Add(new MailboxAddress(_emailSettings.SenderName,
                _emailSettings.SenderEmail));

            message.To.Add(new MailboxAddress(receiverName, receiverEmail));
            message.Subject = subject;

            var builder = new BodyBuilder();
            builder.HtmlBody = body;
            message.Body = builder.ToMessageBody();
            try
            {
                using (var client = new SmtpClient())
                {
                    client.Connect(_emailSettings.Host, _emailSettings.Port, SecureSocketOptions.StartTls);
                    client.Timeout = 30000;
                    client.Authenticate(_emailSettings.Username, _emailSettings.Password);

                    client.Send(message);
                    client.Disconnect(true);
                }
            }
            catch(Exception ex)
            {

            }
            
        }
    }
}
