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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GmsIniTools {
    /// <summary>
    /// IndexPage.xaml 的交互逻辑
    /// </summary>
    public partial class IndexPage : Page {
        public IndexPage() {
            InitializeComponent();
        }



        private void ManagerButton_Click(object sender, RoutedEventArgs e) {
            ChangePage(new ManagePage());
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e) {
            ChangePage(new CreatePage());
        }


        private void WriterButton_Click(object sender, RoutedEventArgs e) {

        }

        private void HelpButton_Click(object sender, RoutedEventArgs e) {

        }

        private void OpenGitHubButton_click(object sender, RoutedEventArgs e) {
            string myGitHubUrl = "https://www.github.com/Phreework";
            System.Diagnostics.Process.Start(myGitHubUrl);
        }

        private void OpenMybili_click(object sender, RoutedEventArgs e) {
            string myGitHubUrl = "https://www.bilibili.com/";
            System.Diagnostics.Process.Start(myGitHubUrl);
        }

        private void OpenExample_click(object sender, RoutedEventArgs e) {
            string myGitHubUrl = "https://www.github.com/Phreework";
            System.Diagnostics.Process.Start(myGitHubUrl);
        }



        #region tools Method
        private void ChangePage(Page page) {
            Window mainwin = Application.Current.MainWindow;
            mainwin.Content = page;
        }
        #endregion
    }
}
