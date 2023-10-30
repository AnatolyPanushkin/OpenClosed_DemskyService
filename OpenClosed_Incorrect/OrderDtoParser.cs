using System.Xml.Serialization;
using OpenClosed_Incorrect.Dtos;

namespace OpenClosed_Incorrect;

public class OrderDtoParser
{ 
    public OrderDto ParseOrderDto(string file, string servicename)
    {
        StringReader reader = new StringReader(file);
        switch (servicename)
        {
            case "service1":
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Service1));
                var service1 = (Service1) serializer.Deserialize(reader);
                return ParseService1(service1);
            }
            case "service2":
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Service2));
                var service2 = (Service2) serializer.Deserialize(reader);
                return ParseService2(service2);
            }
            case "service3":
            {
                return ParseService3(file);
            }
        }

        throw new Exception();
    }
       

    OrderDto ParseService1(Service1 service1)
    {
        return new OrderDto();
    }

    OrderDto ParseService2(Service2 service2)
    {
        return new OrderDto();
    }

    OrderDto ParseService3(string service3)
    {
        return new OrderDto();
    }

}