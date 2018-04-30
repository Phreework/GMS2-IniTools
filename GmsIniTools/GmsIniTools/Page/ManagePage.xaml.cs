using GmsIniTools.Class.Manager;
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
    public partial class ManagePage : Page
    {
        private IniManager iniManager = new IniManagerNormal();

        public ManagePage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e) {
            ChangePage(new IndexPage());
        }





        private void ChooseButton_Click(object sender, RoutedEventArgs e) {
            srcLabel.Content += iniManager.GetIniFilePath();
        }

        #region tools Method
        private void ChangePage(Page page) {
            Window mainwin = Application.Current.MainWindow;
            mainwin.Content = page;
        }
        #endregion
        #region Extra Method
        
        #endregion






        //OperIni.ReadIni("1", "peo_id", "wrong", dialog.FileName);
        //OperIni.WriteIni("1", "peo_id", "ljhaha", dialog.FileName);
        //OperIni.DeleteKey("section", "key1", strFilePath);
        //OperIni.DeleteSection("section", strFilePath);
    }
}
