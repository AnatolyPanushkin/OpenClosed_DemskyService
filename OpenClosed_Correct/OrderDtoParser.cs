using OpenClosed_Correct.Services;
using OpenClosed_Incorrect.Dtos;

namespace OpenClosed_Correct;

public class OrderDtoParser
{
    public OrderDto GetOrder(string serviceName, string data)
    {
        switch (serviceName)
        {
            case "service2":
            {
                return new Service2(data).Parse();
            }
            case "service1":
            {
                return new Service1(data).Parse();
            }
            case "service3":
            {
                return new Service3(data).Parse();
            }
        }

        throw new Exception();
    }
}