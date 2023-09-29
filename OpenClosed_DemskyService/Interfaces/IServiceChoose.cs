namespace OpenClosed_DemskyService.Interfaces;

public interface IServiceChoose<T>
{
    bool IsSuitableService(T service);
}