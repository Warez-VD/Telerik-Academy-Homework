using System;
using System.Xml.Serialization;

namespace SuperHeroes.Export.XmlModels
{
    [Serializable]
    public class PlanetXmlModel
    {
        [XmlElement("planet")]
        public string Planet { get; set; }
    }
}
