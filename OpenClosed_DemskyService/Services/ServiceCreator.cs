using OpenClosed_DemskyService.DTOs;
using OpenClosed_DemskyService.Interfaces;

namespace OpenClosed_DemskyService.Services;

public class ServiceCreator:IServiceCreator<Service>
{
    public Service CreateService(IEnumerable<Service> services, IServiceChoose<Service> serviceChoose)
    {
        return services.FirstOrDefault(serv => serviceChoose.IsSuitableService(serv));
    }
}