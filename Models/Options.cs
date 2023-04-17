namespace SpacePortDockingAPI.Models
{
    //https://json2csharp.com/
    public class Database
    {
        public string dbFileName { get; set; }
    }

    public class TextContent
    {
        public TowerTextContent towerTextContent { get; set; }
    }

    public class TowerTextContent
    {
        public string pingMesssage { get; set; }
    }

    public class AppOptions
    {
        public Database database { get; set; }
        public TextContent textContent { get; set; }
    }
}
