using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Servise
{
    public static class RequestHelper
    {
        private static readonly XmlSerializer Xs = new XmlSerializer(typeof(RepairRequest));
        public static void WriteToFile(string fileName, RepairRequest data)
        {
            using (var fileStream = File.Create(fileName))
            {
                Xs.Serialize(fileStream, data);
            }
        }

        public static RepairRequest LoadFromFile(string fileName)
        {
            using (var fileStream = File.OpenRead(fileName))
            {
                return (RepairRequest)Xs.Deserialize(fileStream);
            }
        }
        public static RepairRequest LoadFromStream(Stream file)
        {
            return (RepairRequest)Xs.Deserialize(file);
        }
    }
}
