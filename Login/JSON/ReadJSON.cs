using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json;

namespace Login.JSON
{
    internal class ReadJSON
    {
        private string _sReadInfo;
        private static string _sPathToDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static string _sFileName = "\\UserInfo.json";
        private static string _sPathToFile = _sPathToDirectory + "\\MessengerName" + _sFileName;

        private string _sName;
        private string _sPassword;
        private string _sMacAddress;
        private string _sUUID;

        public ReadJSON()
        {

        }

        public string readJSON(string type)
        {
            string sReturnString = String.Empty;

            getInfo();

            switch (type)
            {
                case "MacAddress":
                    sReturnString = _sMacAddress;
                    break;
                case "Name":
                    sReturnString = _sName;
                    break;
                case "Password":
                    sReturnString = _sPassword;
                    break;
                case "UUID":
                    sReturnString = _sUUID;
                    break;
                default:
                    //Exception must be adressed
                    throw new Exception();
            }

            return sReturnString;
        }

        private void getInfo()
        {

        }

        private void formatInfo()
        {

        }
    }
}
