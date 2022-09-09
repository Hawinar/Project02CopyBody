using System.Collections.Generic;
using System.Windows;
using Project02TestModule;

namespace Project02CopyBody
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static string Path = "C:\\Users\\Admin\\Desktop\\DBaccounts.txt";
        public List<Account> accountsList = new List<Account>();

        private void btReg_Click(object sender, RoutedEventArgs e)
        {
            if (tbSNP.Text != string.Empty && tbPassword.Text != string.Empty)
            {
                string SNP = tbSNP.Text;
                string inputSNP = tbSNP.Text;
                string Password = tbPassword.Text;
                string inputPassword = tbPassword.Text;
                Account accounts = new Account(SNP, Password, "Клиент");
                accounts.Register(SNP, Password, "Клиент", Path, inputSNP, inputPassword);
                string Responde = accounts.Response;
                if (Responde == "Такой уже есть")
                {
                    MessageBox.Show("Такой пользователь уже зарегестрирован");
                }

            }
        }

        private void btLogin_Click(object sender, RoutedEventArgs e)
        {
            if (tbSNP.Text != string.Empty && tbPassword.Text != string.Empty)
            {
                string SNP = tbSNP.Text;
                string Password = tbPassword.Text;
                string inputSNP = tbSNP.Text;
                string Role = string.Empty;
                string inputPassword = tbPassword.Text;

                Account accounts = new Account(SNP, Password, Role);

                string Response = accounts.Login(SNP, Password, Role, Path, inputSNP, inputPassword);

                if (Response == "SC")
                {
                    WindowClient WC = new WindowClient();
                    WC.Show();
                    WC.WelcomeSNP.Content = tbSNP.Text;
                }
                else if (Response == "SE")
                {
                    WindowEmployee WE = new WindowEmployee();
                    WE.Show();
                    WE.WelcomeSNP.Content = tbSNP.Text;
                }
                else
                {
                    MessageBox.Show("Введены неверные данные");
                }

            }




        }
    }
}
