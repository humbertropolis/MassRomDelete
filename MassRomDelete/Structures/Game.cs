using System.Xml.Serialization;

namespace MassRomDelete.Structures
{
    public class Game
    {
        [XmlElement("path")]
        public string Path { get; set; }
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("desc")]
        public string Description { get; set; }
        [XmlElement("image")]
        public string Image { get; set; }
        [XmlElement("rating")]
        public double Rating { get; set; }
        [XmlElement("releasedate")]
        public int ReleaseDate { get; set; }
        [XmlElement("developer")]
        public string Developer { get; set; }
        [XmlElement("publisher")]
        public string Publisher { get; set; }
        [XmlElement("genre")]
        public string Genre { get; set; }
        [XmlElement("players")]
        public int Players { get; set; }
    }
}
