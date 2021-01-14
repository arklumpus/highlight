using System.Xml.Linq;

namespace Highlight.Configuration
{
    public class DefaultConfiguration : XmlConfiguration
    {
        public DefaultConfiguration()
        {
            using (System.IO.Stream sr = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Highlight.Resources.DefaultDefinitions.xml"))
            {
                using (System.IO.StreamReader reader = new System.IO.StreamReader(sr))
                {
                    XmlDocument = XDocument.Parse(reader.ReadToEnd());
                }
            }
        }
    }
}