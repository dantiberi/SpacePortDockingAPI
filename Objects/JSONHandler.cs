using Newtonsoft.Json;
using SpacePortDockingAPI.Models;

namespace SpacePortDockingAPI.Objects
{
    public class JSONHandler
    {
        public static AppOptions? appOptions;
        static string codePath = Environment.CurrentDirectory;

        public static AppOptions LoadOptionsJson()
        {
            string path = codePath + "/Res/options.json";
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                AppOptions appOptions = JsonConvert.DeserializeObject<AppOptions>(json);

                if(appOptions == null) throw new IOException($"options.json not found at {path}");

                return appOptions;
            }
        }
    }
}
