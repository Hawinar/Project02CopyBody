using System.Collections.Generic;
using System.Windows;
using Project02TestModule;

namespace Project02CopyBody
{
    /// <summary>
    /// Логика взаимодействия для WindowEmployee.xaml
    /// </summary>
    public partial class WindowEmployee : Window
    {
        public WindowEmployee()
        {
            InitializeComponent();
        }
        public static string Path = "C:\\Users\\Admin\\Desktop\\DBorders.txt";
        public List<Order> ordersList = new List<Order>();
        public static int OrderId = 1;

        private void GetOrderAtId_Click(object sender, RoutedEventArgs e)
        {
            if (tbFoundAtId.Text != string.Empty)
            {
                string inputId = tbFoundAtId.Text;
                string SNP = WelcomeSNP.Content.ToString();
                string baseSNP = WelcomeSNP.Content.ToString();
                string Vendor = "Неизвестно";
                string Model = "Неизвестно";
                string TypeOfWork = "Неизвестно";
                string Cost = "Неизвестно";
                string DateOfAcceptance = "Не принято";
                string Status = "Ожидание";
                Order orders = new Order(inputId, baseSNP, Vendor, Model, TypeOfWork, Cost, DateOfAcceptance, Status);
                orders.GetOrderAtId(inputId, Path);
                labelSNPvendorModelWork.Content = orders.SNPvendorModelWork;
                tbCost.Text = orders.OutputCost;
                tbDateOfAcceptance.Text = orders.OutputDateOfAcceptance;
                tbStatus.Text = orders.OutputStatus;
            }
        }

        private void ChangeOrder_Click(object sender, RoutedEventArgs e)
        {
            if (tbCost.Text != string.Empty && tbDateOfAcceptance.Text != string.Empty && tbStatus.Text != string.Empty)
            {
                string inputId = tbFoundAtId.Text;
                string SNP = WelcomeSNP.Content.ToString();
                string baseSNP = WelcomeSNP.Content.ToString();
                string Vendor = "Неизвестно";
                string Model = "Неизвестно";
                string TypeOfWork = "Неизвестно";
                string Cost = "Неизвестно";
                string DateOfAcceptance = "Не принято";
                string Status = "Ожидание";
                Order orders = new Order(inputId, baseSNP, Vendor, Model, TypeOfWork, Cost, DateOfAcceptance, Status);
                string newCost = tbCost.Text;
                string newDateOfAcceptance = tbDateOfAcceptance.Text;
                string newStatus = tbStatus.Text;
                orders.ChangeOrder(inputId, Path, newCost, newDateOfAcceptance, newStatus);
            }
        }
    }
}
