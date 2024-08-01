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
        private JsonSerializerOptions options;

        private string fullPath;
        string info;

        public ReadJSON(string fullPath, JsonSerializerOptions options)
        {
            this.fullPath = fullPath;
            this.options = options;
        }

        public JSONObject? readJSON()
        {
            JSONObject readInfo = getInfo();

            return readInfo;
        }

        private JSONObject getInfo()
        {
            JSONObject json;

            string info = File.ReadAllText(fullPath);

            json = JsonSerializer.Deserialize<JSONObject>(fullPath, options)!;

            return json;
        }
    }
}
