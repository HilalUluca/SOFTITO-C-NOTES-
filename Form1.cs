using System;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Burada otomatik metod oluştu(neye göre tek çift kontrol etsin textbox1)

            int sayi = Convert.ToInt32(textBox1.Text);  //daha önce konsoldan aldığım için konsol diyordum
            if (sayi % 2 == 0)
            {
                MessageBox.Show($"{sayi}çift");
            }
            else
            {
                MessageBox.Show($"{sayi}tek");

            }
        }
    }
}
