using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Logging;

namespace Soda.DummyEmailSender;

public class ConsoleLoggingEmailSender : IEmailSender
{
    private readonly ILogger<ConsoleLoggingEmailSender> _logger;

    protected ConsoleLoggingEmailSender(ILogger<ConsoleLoggingEmailSender> logger)
    {
        _logger = logger;
    }

    public virtual Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        _logger.LogInformation("Sending email to {email} with subject {subject}", email, subject);
        _logger.LogInformation(htmlMessage);

        return Task.CompletedTask;
    }
}
