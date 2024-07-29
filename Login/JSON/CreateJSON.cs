using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.JSON
{
    internal class CreateJSON
    {
        private static readonly string _sApplicationDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static readonly string _sPath = _sApplicationDataDir + "\\MessengerName";

        private const string _sFileName = "\\UserInfo.json";

        private static string _sPathToFile = _sPath + _sFileName;

        private FileStream fs;

        public CreateJSON() 
        {
        
        }

        public bool createJSON()
        {
            CreateDir();
            pCreateJSON();

            return false;
        }

        private bool CreateDir()
        {
            try
            {
                if (Directory.Exists(_sPath))
                {
                    return true;
                }
                else
                {
                    Directory.CreateDirectory(_sPath);
                    return true;
                }   
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private bool pCreateJSON()
        {
            if (File.Exists(_sPathToFile))
            {
                return true;
            }
            else
            {
                fs = File.Create(_sPathToFile);

                pCreateJSON();
            }

            return false;
        }
    }
}
