using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmsIniTools.Class.Manager {
    abstract class IniManager {
        public string filePath;

        public string GetIniFilePath() {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "文本文件|*.ini";
            if ((bool)dialog.ShowDialog()) {
                filePath = dialog.FileName;
            }
           

            return filePath;
        }
    }
}
