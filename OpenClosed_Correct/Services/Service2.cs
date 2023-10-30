using System.Xml.Serialization;
using OpenClosed_Correct.Interfaces;
using OpenClosed_Incorrect.Dtos;

namespace OpenClosed_Correct.Services;

public class Service2:IOrderParser
{
    private readonly string _serviceData;
    public Service2(string sirenaStr)
    {
        _serviceData = sirenaStr;
    }
    
    public OrderDto Parse()
    {
        var service2Dto = ServiceSerializer.SerializeToService<Service2Dto>(_serviceData);
        return ToOrder(service2Dto);
    }
    
    public static OrderDto ToOrder(Service2Dto service2Dto)
    {
        return new OrderDto();
    }
}