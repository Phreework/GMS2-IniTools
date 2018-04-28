using GmsIniTools.Class;
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
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
        }

        private static void OpenIniFile() {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "文本文件|*.ini";
            string filePath = dialog.FileName;
            if (dialog.ShowDialog() == true) {
                //dosomething
            }
        }

        private void ManagerButton_Click(object sender, RoutedEventArgs e) {

        }

        private void CreateButton_Click(object sender, RoutedEventArgs e) {

        }


        private void WriterButton_Click(object sender, RoutedEventArgs e) {

        }

        private void HelpButton_Click(object sender, RoutedEventArgs e) {

        }

        private void OpenGitHubButton_click(object sender, RoutedEventArgs e) {
            string myGitHubUrl = "www.baidu.com";
            System.Diagnostics.Process.Start(myGitHubUrl);
        }

        private void OpenExample_click(object sender, RoutedEventArgs e) {

        }


        //OperIni.ReadIni("1", "peo_id", "wrong", dialog.FileName);
        //OperIni.WriteIni("1", "peo_id", "ljhaha", dialog.FileName);
        //OperIni.DeleteKey("section", "key1", strFilePath);
        //OperIni.DeleteSection("section", strFilePath);
    }
}
