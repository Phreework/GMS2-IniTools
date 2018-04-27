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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e) {

            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "文本文件|*.ini";
            if (dialog.ShowDialog() == true) {
                OperIni.DeleteSection("1", dialog.FileName);
                TextBox1.Text = OperIni.ReadIni("1", "peo_id", "wrong", dialog.FileName);
            }


            //OperIni.ReadIni("1", "peo_id", "wrong", dialog.FileName);
            //OperIni.WriteIni("1", "peo_id", "ljhaha", dialog.FileName);
            //OperIni.DeleteKey("section", "key1", strFilePath);
            //OperIni.DeleteSection("section", strFilePath);
        }
    }
}
