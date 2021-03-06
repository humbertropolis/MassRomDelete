﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace MassRomDelete.Structures
{
    [XmlRoot("gameList")]
    public class GameList
    {
        [XmlElement("game")]
        public List<Game> Games { get; set; }
    }
}
