using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Bot_Discord
{
    class Utilities
    {

        private static Dictionary<string, string> alerts;

        internal static void GetAlert(int v)
        {
            throw new NotImplementedException();
        }

        static Utilities()
        {

            string json = File.ReadAllText("SystemLong/alerts.json");
            var data = JsonConvert.DeserializeObject<dynamic>(json);
            alerts = data.ToObject<Dictionary<string, string>>(); 

        }

        public static string GetAlert(string key)
        {
            if (alerts.ContainsKey(key)) return alerts[key];
            return "";
        }
        
      
    }
}
