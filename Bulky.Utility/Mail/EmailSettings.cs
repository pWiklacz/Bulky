﻿namespace Bulky.Utility.Mail;
public class EmailSettings
{
    public string Server { get; set; } = null!;
    public int Port { get; set; }
    public string SenderName { get; set; } = null!;
    public string SenderEmail { get; set; } = null!;
    public string UserName { get; set; } = null!;
    public string Password { get; set; } = null!;
}