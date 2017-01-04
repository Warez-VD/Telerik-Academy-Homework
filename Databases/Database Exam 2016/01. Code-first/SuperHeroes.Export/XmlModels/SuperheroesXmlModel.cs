using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SuperHeroes.Export.XmlModels
{
    [Serializable]
    [XmlRoot("superheroes")]
    public class SuperheroesXmlModel
    {
        [XmlElement("superhero")]
        public List<SuperheroXmlModel> Superheroes { get; set; }
    }
}
