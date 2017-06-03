using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using HomeAccountant.Model;
using HomeAccountant.Repository;
using HomeAccountant.Model.Domain;
using NHibernate.Exceptions;

namespace HomeAccountant
{
    /// <summary>
    /// Interaction logic for LogInWindow.xaml
    /// </summary>
    public partial class LogInWindow : Window
    {
        public UserDataRepository UserRepository { get; set; }
        public SessionStorage SessionStorage { get; set; }

        public LogInWindow()
        {
            SetUp();
            InitializeComponent();
        }

        private void SetUp()
        {
            UserRepository = new UserDataRepository();
            SessionStorage = SessionStorage.Instance;
        }

        private void LogInBtn_Click(object sender, RoutedEventArgs e)
        {
            Trace.TraceInformation($"---------- Login Button Click. Username: {UserNameTB.Text} ----------");
            ErrorMessageLabel.Content = "";
            UserData user = UserRepository.GetByUserName(UserNameTB.Text);
            if (user == null)
            {
                Trace.TraceInformation($"Not registered username");
                ErrorMessageLabel.Content = "Not Registered UserName";
                return;
            }

            Trace.TraceInformation($"Successfully logged in -- Redirecting to the main page");
            SessionStorage.LoggedInUser = user;
            Application.Current.MainWindow.Show();
            this.Close();
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UserRepository.SaveNewUser(UserNameTB.Text);
            }
            catch (GenericADOException)
            {
                ErrorMessageLabel.Content = "Username already in use";
            }
        }
    }
}
