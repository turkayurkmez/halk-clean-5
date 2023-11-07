// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");
Report report1 = new Report(new MailSender());
Report report2 = new Report(new WhatsAppSender());
