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
        [DllImport("kernel32")]
        private static extern uint GetPrivateProfileString(

            string lpAppName, // points to section name

            string lpKeyName, // points to key name

            string lpDefault, // points to default string

            byte[] lpReturnedString, // points to destination buffer

            uint nSize, // size of destination buffer

            string lpFileName  // points to initialization filename

        );

        public static List<string> ReadSections(string iniFilename) {

            List<string> result = new List<string>();

            byte[] buf = new byte[65536];

            uint len = GetPrivateProfileString(null, null, null, buf, (uint)buf.Length, iniFilename);

            int j = 0;

            for (int i = 0; i < len; i++)

                if (buf[i] == 0) {

                    result.Add(Encoding.Default.GetString(buf, j, i - j));

                    j = i + 1;

                }

            return result;

        }
        public static List<string> ReadSingleSection(string Section, string iniFilename) {

            List<string> result = new List<string>();

            byte[] buf = new byte[65536];

            uint lenf = GetPrivateProfileString(Section, null, null, buf, (uint)buf.Length, iniFilename);

            int j = 0;

            for (int i = 0; i < lenf; i++)

                if (buf[i] == 0) {

                    result.Add(Encoding.Default.GetString(buf, j, i - j));

                    j = i + 1;

                }

            return result;

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
