using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PraktikHome
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string sumbols = "1234567890qwertyiopKLJHGFDSQWERTYUIOMBVCXzxcvbnmasdfghjkl";
        static Random r = new Random();
        public MainWindow()
        {
            InitializeComponent();

            var captchaText = sumbols[r.Next(sumbols.Length)].ToString() +
                sumbols[r.Next(sumbols.Length)].ToString() +
                sumbols[r.Next(sumbols.Length)].ToString() +
                sumbols[r.Next(sumbols.Length)].ToString();

            Captcha.Text = captchaText;
            

       
        }

        private void Captcha_button(object sender, RoutedEventArgs e)
        {
            if (Captcha_Box.Text == null || Captcha_Box.Text != Captcha.Text)
            {
                var captchaText = sumbols[r.Next(sumbols.Length)].ToString() +
                 sumbols[r.Next(sumbols.Length)].ToString() +
                 sumbols[r.Next(sumbols.Length)].ToString() +
                 sumbols[r.Next(sumbols.Length)].ToString();

                Captcha.Text = captchaText;
                MessageBox.Show("Капча введена неверно!");
            }
            else if (Captcha_Box.Text == Captcha.Text)
            {
                MessageBox.Show("Капча верна!");
            }
            else
            {
                MessageBox.Show("Внезапная ошибка!");
            }
        }
    }
}
