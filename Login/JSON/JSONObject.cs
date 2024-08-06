using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Login.JSON
{
    internal class JSONObject
    {
        [JsonPropertyName("Name")]
        private string? sName { get; set; }

        [JsonPropertyName("Password")]
        private string? sPassword { get; set; }

        [JsonPropertyName("Mac")]
        private string? sMac { get; set; }

        [JsonPropertyName("UUID")]
        private string? sUUID { get; set; }
    }
}
