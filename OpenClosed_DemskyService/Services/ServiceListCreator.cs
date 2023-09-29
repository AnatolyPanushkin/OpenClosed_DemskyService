using OpenClosed_DemskyService.DTOs;
using OpenClosed_DemskyService.Interfaces;

namespace OpenClosed_DemskyService.Services;

public static class ServiceListCreator
{
    public static List<Service> _servicesList;

    static ServiceListCreator()
    {
        _servicesList = new List<Service>();
    }
}