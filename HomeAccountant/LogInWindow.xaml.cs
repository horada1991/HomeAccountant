using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using HomeAccountant.Repository;
using HomeAccountant.Model.Domain;

namespace HomeAccountant
{
    /// <summary>
    /// Interaction logic for LogInWindow.xaml
    /// </summary>
    public partial class LogInWindow : Window
    {
        public UserDataRepository UserRepository { get; set; }

        public LogInWindow()
        {
            SetUp();
            InitializeComponent();
        }

        private void SetUp()
        {
            UserRepository = new UserDataRepository();
        }

        private void LogInBtn_Click(object sender, RoutedEventArgs e)
        {
            UserData user = UserRepository.GetByUserName(UserNameTB.Text);
            if (user == null) ErrorMessageLabel.Content = "Not Registered UserName";
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            UserRepository.SaveNewUser(UserNameTB.Text);
        }
    }
}
