using System.Xml.Serialization;

namespace OpenClosed_Correct.Services;

public static class ServiceSerializer
{
    public static T SerializeToService<T>(string data)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(string));
        
        StringReader reader = new StringReader(data);

        return (T) serializer.Deserialize(reader);
    }
}