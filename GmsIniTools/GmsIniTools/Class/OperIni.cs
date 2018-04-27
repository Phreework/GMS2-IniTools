using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GmsIniTools.Class {
    public class OperIni {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string value, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string defValue, StringBuilder retvalue, int size, string filePath);
        //读取ini
        public static string ReadIni(string section, string key, string noText, string filePath) {
            if (File.Exists(filePath)) {
                StringBuilder temp = new StringBuilder(1024);
                GetPrivateProfileString(section, key, noText, temp, 1024, filePath);
                return temp.ToString();
            } else {
                return String.Empty;
            }
        }
        //写入ini
        public static bool WriteIni(string section, string key, string value, string filePath) {
            if (File.Exists(filePath)) {
                long OpStation = WritePrivateProfileString(section, key, value, filePath);
                if (OpStation == 0) {
                    return false;
                } else {
                    return true;
                }
            } else {
                return false;
            }
        }
        //删除节
        public static long DeleteSection(string section, string filePath) {
            return WritePrivateProfileString(section, null, null, filePath);
        }
        //删除键
        public static long DeleteKey(string section, string key, string filePath) {
            return WritePrivateProfileString(section, key, null, filePath);
        }
    }
}
