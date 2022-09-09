using System.Collections.Generic;
using System.Windows;
using Project02TestModule;

namespace Project02CopyBody
{
    /// <summary>
    /// Логика взаимодействия для WindowClient.xaml
    /// </summary>
    public partial class WindowClient : Window
    {
        public WindowClient()
        {
            InitializeComponent();
        }
        public static string OrderId;
        public static string Path = "C:\\Users\\Admin\\Desktop\\DBorders.txt";
        public List<Order> ordersList = new List<Order>();
        private void makeOrder_Click(object sender, RoutedEventArgs e)
        {
            if (tbVendor.Text != string.Empty || tbModel.Text != string.Empty || tbTypeOfWork.Text != string.Empty)
            {
                string SNP = WelcomeSNP.Content.ToString();
                string Cost = "Неизвестно";
                string DateOfAcceptance = "Не принято";
                string Status = "Ожидание";
                Order orders = new Order(OrderId, SNP, tbVendor.Text, tbModel.Text, tbTypeOfWork.Text, Cost, DateOfAcceptance, Status);
                orders.MakeClientOrder(OrderId, SNP, tbVendor.Text, tbModel.Text, tbTypeOfWork.Text, Cost, DateOfAcceptance, Status, Path);
                tbVendor.Text = string.Empty;
                tbModel.Text = string.Empty;
                tbTypeOfWork.Text = string.Empty;
            }
        }

        private void GetMyOrders_Click(object sender, RoutedEventArgs e)
        {
            string SNP = WelcomeSNP.Content.ToString();
            string baseSNP = WelcomeSNP.Content.ToString();
            string Cost = "Неизвестно";
            string DateOfAcceptance = "Не принято";
            string Status = "Ожидание";
            Order orders = new Order(OrderId, baseSNP, tbVendor.Text, tbModel.Text, tbTypeOfWork.Text, Cost, DateOfAcceptance, Status);
            orders.GetMyOrders(baseSNP, Path);
            lableOrdersList.Content = orders.ordersHistory.ToString();
        }
    }
}
