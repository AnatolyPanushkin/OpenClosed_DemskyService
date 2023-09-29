using OpenClosed_DemskyService.DTOs;

namespace OpenClosed_DemskyService.Interfaces;

public interface IServiceListCreator
{
    public void AddService(Service service);

    public List<Service> ReturnListServices();
}