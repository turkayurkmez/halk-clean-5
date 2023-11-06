namespace SingleResponsible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            double price = double.Parse(textBoxPrice.Text);

            createProduct(name, price);
        }

        private void createProduct(string name, double price)
        {
            sendMail("info@hedehodo.com");
        }

        private void sendMail(string mail)
        {
            Console.WriteLine("mail gönderildi");
        }
    }
}