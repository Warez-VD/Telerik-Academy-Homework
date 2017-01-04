using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SuperHeroes.Export.XmlModels
{
    [Serializable]
    public class FractionXmlModel
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("members")]
        public int Members { get; set; }

        [XmlElement("planets")]
        public List<PlanetXmlModel> Planets { get; set; }
    }
}
