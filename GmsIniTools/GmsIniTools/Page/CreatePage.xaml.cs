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

namespace GmsIniTools
{
    /// <summary>
    /// CreatePage.xaml 的交互逻辑
    /// </summary>
    public partial class CreatePage : Page
    {
        public CreatePage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e) {
            ChangePage(new IndexPage());
        }



        #region tools Method
        private void ChangePage(Page page) {
            Window mainwin = Application.Current.MainWindow;
            mainwin.Content = page;
        }
        #endregion
    }
}
