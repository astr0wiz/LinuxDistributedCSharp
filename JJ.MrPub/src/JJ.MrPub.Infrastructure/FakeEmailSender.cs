﻿using JJ.MrPub.Core.Interfaces;

namespace JJ.MrPub.Infrastructure;

public class FakeEmailSender : IEmailSender
{
  public Task SendEmailAsync(string to, string from, string subject, string body)
  {
    return Task.CompletedTask;
  }
}
