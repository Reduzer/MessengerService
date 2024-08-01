using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.JSON
{
    internal class CreateJSON
    {
        private string sDirPath;

        private FileStream fs;

        public CreateJSON(string dirPath) 
        {
            this.sDirPath = dirPath;
        }

        public bool CreateDir()
        {
            try
            {
                if (Directory.Exists(sDirPath))
                {
                    return true;
                }
                else
                {
                    Directory.CreateDirectory(sDirPath);
                    return true;
                }   
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
        }
    }
}
