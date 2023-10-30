using System.Xml.Serialization;
using OpenClosed_Correct.Interfaces;
using OpenClosed_Incorrect.Dtos;

namespace OpenClosed_Correct.Services;

public class Service1:IOrderParser
{
    private readonly XmlSerializer serializer = new XmlSerializer(typeof(string));
    
    private Service1Dto _service1;

    public Service1(string service1Str)
    {
        StringReader reader = new StringReader(service1Str);
        _service1 = (Service1Dto) serializer.Deserialize(reader);
    }
    
    public OrderDto Parse()
    {
        return ToOrder(_service1);
    }

    public OrderDto ToOrder(Service1Dto service1Dto)
    {
        return new OrderDto();
    }
}