using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Login.JSON
{
    internal class WriteToJSON
    {
        private string path;

        public WriteToJSON(string pathToFile)
        {
            path = pathToFile;

        }

        public void writeToJSON(JSONObject Info, JsonSerializerOptions options)
        {

        }


    }
}
