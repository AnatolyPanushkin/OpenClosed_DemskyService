using OpenClosed_DemskyService.DTOs;
using OpenClosed_DemskyService.Interfaces;

namespace OpenClosed_DemskyService.Services;

public class ServiceChoose:IServiceChoose<Service>
{
    private readonly string _serviceName;

    public ServiceChoose(string serviceName)
    {
        _serviceName = serviceName;
    }

    public bool IsSuitableService(Service serviceName) => serviceName.ServiceType == _serviceName;

}