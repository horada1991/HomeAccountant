using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using HomeAccountant.Model.Domain;
using HomeAccountant.Model;

namespace HomeAccountant
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SessionStorage Session { get; set; }
        public LogInWindow LogInWindow { get; set; }

        public MainWindow()
        {
            SetupApp();
            CheckLogInStatus();
            InitializeComponent();
        }

        private void SetupApp()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetCurrentDirectory() + "\\Data");

            List<Type> domainTypes = new List<Type>();
            domainTypes.Add(typeof(UserData));
            NHibernateHelper.LoadNHibernateCfg(domainTypes);

            Session = new SessionStorage();
            LogInWindow = new LogInWindow();
        }

        private void CheckLogInStatus()
        {
            if (Session.LoggedInUser == null)
            {
                LogInWindow.Show();
                this.Close();
            }
        }
    }
}
