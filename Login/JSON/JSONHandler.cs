using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Login.JSON
{
    internal class JSONHandler
    {
        private ReadJSON m_JsonRead;
        private WriteToJSON m_WriteToJSON;
        private CreateJSON m_CreateJSON;

        private JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

        private static string? _sPathToDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\MessengerName";
        private static string? _sFileName = "\\UserInfo.json";
        private static string? _sPathToFile = _sPathToDirectory + _sFileName;


        public JSONHandler()
        {
            m_JsonRead = new ReadJSON(_sPathToFile, options);
            m_CreateJSON = new CreateJSON(_sPathToDirectory);
            m_WriteToJSON = new WriteToJSON(_sPathToFile);
        }

        /// <summary>
        /// WIP needs to add the strings to the Dictonary
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> readJSON()
        {
            Dictionary<string, string> infos = new Dictionary<string, string>();


            return infos;
        }

        public void writeJSON(string[] info)
        {
            m_WriteToJSON.writeToJSON(StringToJSON(info), options);
        }

        public void firstTimeSetup(string[] info)
        {
            m_CreateJSON.CreateDir();
            m_WriteToJSON.writeToJSON(StringToJSON(info), options);
        }

        private JSONObject StringToJSON(string[] info)
        {
            StringBuilder sb_json = new StringBuilder();

            return null; 
        }
    }
}
