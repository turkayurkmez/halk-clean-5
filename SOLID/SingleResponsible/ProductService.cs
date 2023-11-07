namespace SingleResponsible
{
    public class ProductService
    {
        /*
         * Ürün hizmetlerinden sorumluyum. Ekleme, silme
         * güncelleme işlemlerini ilgili nesneler üzerinden ben hallederim.
         */
        public void Create(string name, double price)
        {
            Console.WriteLine("Ürün eklendi");
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.Execute("Insert into....");
            MailSender mailSender = new MailSender();
            mailSender.Send("test@bidibidi.com");
        }
    }
}
