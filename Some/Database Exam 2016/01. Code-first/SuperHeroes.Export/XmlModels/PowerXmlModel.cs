using System;
using System.Xml.Serialization;

namespace SuperHeroes.Export.XmlModels
{
    [Serializable]
    public class PowerXmlModel
    {
        [XmlElement("power")]
        public string Power { get; set; }
    }
}
