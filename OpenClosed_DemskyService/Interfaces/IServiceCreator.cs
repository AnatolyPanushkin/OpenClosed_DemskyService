using OpenClosed_DemskyService.DTOs;

namespace OpenClosed_DemskyService.Interfaces;

public interface IServiceCreator<T>
{
    Service CreateService(IEnumerable<Service> services, IServiceChoose<T> serviceChoose);
}