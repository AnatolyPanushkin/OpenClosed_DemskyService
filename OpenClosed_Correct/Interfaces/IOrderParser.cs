using OpenClosed_Incorrect.Dtos;

namespace OpenClosed_Correct.Interfaces;

public interface IOrderParser
{
    public OrderDto Parse();
}