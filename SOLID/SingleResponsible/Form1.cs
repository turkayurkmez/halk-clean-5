namespace SingleResponsible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * Benim sorumluluğum 
         *   kullanıcıdan veri almak, bu veriyi sorumlu nesneye göndermek.
         *   kullanıcının tetiklediği olayları yakalamak (butona tıklamak)
         */
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            double price = double.Parse(textBoxPrice.Text);

            new ProductService().Create(name, price);
        }

        //private void createProduct(string name, double price)
        //{
        //    Console.WriteLine("Ürün eklendi");
        //    sendMail("info@hedehodo.com");
        //}

        //private void sendMail(string mail)
        //{
        //    Console.WriteLine("mail gönderildi");
        //}
    }
}