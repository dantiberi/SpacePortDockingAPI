namespace SpacePortDockingAPI.Models
{
    //https://json2csharp.com/
    public class Database
    {
        public string dbFileName { get; set; }
    }

    public class AppOptions
    {
        public Database database { get; set; }
    }
}
