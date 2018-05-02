using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmsIniTools.Class {
    public class IniType {
        public enum IniFileType {
            ModelType,
            NormalType
        }
        public IniFileType IniFile = IniFileType.NormalType;

        public bool IsNormal() {
            if (IniFile == IniFileType.NormalType)
                return true;
            else
                return false;
        }
    }
}
