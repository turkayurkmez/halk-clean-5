namespace DependencyInversion
{
    public class Report
    {
        private ISender sender;
        public Report(ISender sender)
        {
            this.sender = sender;
        }

        public void Send(string to)
        {
            //MailSender sender = new MailSender();
            sender.Send(to);
        }
    }
    public interface ISender
    {
        void Send(string to);
    }
    public class MailSender : ISender
    {
        public void Send(string to) => Console.WriteLine($"{to} adresine mail atıldı");
    }

    public class WhatsAppSender : ISender
    {
        public void Send(string to)
        {
            throw new NotImplementedException();
        }
    }
    public class SMSSender : ISender
    {
        public void Send(string to)
        {
            throw new NotImplementedException();
        }
    }
}
