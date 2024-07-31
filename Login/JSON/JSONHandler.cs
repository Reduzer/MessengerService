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

        private JsonSerializerOptions options;

        private static string? _sPathToDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static string? _sFileName = "\\UserInfo.json";
        private static string? _sPathToFile = _sPathToDirectory + "\\MessengerName" + _sFileName;


        public JSONHandler()
        {
            m_JsonRead = new ReadJSON();
            m_CreateJSON = new CreateJSON();
            m_JsonRead = new ReadJSON();
            options = new JsonSerializerOptions { WriteIndented = true };
        }

        public string readJSON()
        {
            return String.Empty;
        }

        public void writeJSON(string[] info)
        {
            m_WriteToJSON.writeToJSON(StringToJSON(info), options);
        }

        public void firstTimeSetup()
        {

        }

        private JSONObject StringToJSON(string[] info)
        {
            return null;
        }
    }
}
