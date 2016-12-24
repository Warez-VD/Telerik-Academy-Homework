using SuperHeroes.Export.XmlModels;
using System.IO;
using System.Xml.Serialization;

namespace SuperHeroes.Export
{
    public class XmlExporter
    {
        public void ExportFractionsXml(FractionsXmlModel fractions, string fileName)
        {
            string path = "../../../../03. Xml Files";
            Directory.CreateDirectory(path);
            using (var stream = File.Create($"{path}/{fileName}.xml"))
            {
                var xmlSerializer = new XmlSerializer(typeof(FractionsXmlModel));
                xmlSerializer.Serialize(stream, fractions);
            }
        }

        public void ExportSuperheroesXml(SuperheroesXmlModel superheroes, string fileName)
        {
            string path = "../../../../03. Xml Files";
            Directory.CreateDirectory(path);
            using (var stream = File.Create($"{path}/{fileName}.xml"))
            {
                var xmlSerializer = new XmlSerializer(typeof(SuperheroesXmlModel));
                xmlSerializer.Serialize(stream, superheroes);
            }
        }
    }
}
