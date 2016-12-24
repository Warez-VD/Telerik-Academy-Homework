using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SuperHeroes.Export.XmlModels
{
    [Serializable]
    public class SuperheroXmlModel
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("secretIdentity")]
        public string SecretIdentity { get; set; }

        [XmlElement("alignment")]
        public string Alignment { get; set; }

        [XmlElement("powers")]
        public List<PowerXmlModel> Powers { get; set; }

        [XmlElement("city")]
        public string City { get; set; }
    }
}
