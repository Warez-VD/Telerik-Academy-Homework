using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SuperHeroes.Export.XmlModels
{
    [Serializable]
    [XmlRoot("fractions")]
    public class FractionsXmlModel
    {
        [XmlElement("fraction")]
        public List<FractionXmlModel> Fractions { get; set; }
    }
}
