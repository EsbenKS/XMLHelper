using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization; 

namespace MasterItem.Shared
{
    public class XMLHelper
    {

        public static  ObjectType  ReadXML<ObjectType>(string filename)
        {
            using (var sw = new StreamReader(filename)))
            {
                return (ObjectType)new XmlSerializer(typeof(ObjectType)).Deserialize(sw);
            }
        }

        public static void SaveXml<ObjectType>(ObjectType o, string filename)
        {
            using (var sw = new StreamWriter(filename))
            {
                new XmlSerializer(typeof(ObjectType)).Serialize(sw, o);
            }
        }
    }
}
