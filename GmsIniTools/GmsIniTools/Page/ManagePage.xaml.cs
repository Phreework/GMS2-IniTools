using GmsIniTools.Class;
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
        private IniManager iniManager;

        public ManagePage()
        {
            InitializeComponent();
            MainWindow mainwin = (MainWindow)Application.Current.MainWindow;
            if (mainwin.iniType.IsNormal())
                iniManager = new IniManagerNormal();
            else
                iniManager = new IniManagerModel();

        }

        private void BackButton_Click(object sender, RoutedEventArgs e) {
            ChangePage(new IndexPage());
        }





        private void ChooseButton_Click(object sender, RoutedEventArgs e) {
            srcLabel.Content += iniManager.GetIniFilePath();
            string filePath = iniManager.filePath;
            List<string> section = OperIni.ReadSections(filePath);
            string[] sectionArray = section.ToArray<string>();
            string test = OperIni.ReadIni(sectionArray[0],null,"wrong",filePath);
            for (int i = 0; i < sectionArray.Length; i++) {
                
            }
            testLabel.Content = test;
            //List<string> key = section.

        }

        #region tools Method
        private void ChangePage(Page page) {
            Window mainwin = Application.Current.MainWindow;
            mainwin.Content = page;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }

        private void GridDoubleClick(object sender, MouseButtonEventArgs e) {

            string[] columnName = {"Section","Key","Value" };

            
            List<int[]> list = new List<int[]>();
            list.Add(new int[] { 1, 2, 3});
            list.Add(new int[] { 2, 3, 4});
            list.Add(new int[] { 3, 4, 5});

            int _col = list[0].Length;
            int _row = list.Count;
            for (int i = 0; i < _col; i++) {
                iniDataGrid.Columns.Add(new DataGridTextColumn {
                    Width = 100,
                    Header = columnName[i],
                    Binding = new Binding($"[{i.ToString()}]")
                });
            }
            iniDataGrid.ItemsSource = list;
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
