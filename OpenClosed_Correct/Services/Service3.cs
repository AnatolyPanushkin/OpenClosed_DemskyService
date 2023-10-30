using OpenClosed_Correct.Interfaces;
using OpenClosed_Incorrect.Dtos;

namespace OpenClosed_Correct.Services;

public class Service3:IOrderParser
{
    private string _service3;

    public Service3(string service3)
    {
        _service3 = service3;
    }
    
    public OrderDto Parse()
    {
        return ToOrder(_service3);
    }
    
    public static OrderDto ToOrder(string s7Dto)
    {
        return new OrderDto();
    }
}