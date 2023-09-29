using OpenClosed_DemskyService.Interfaces;
using OpenClosed_DemskyService.Services;

namespace OpenClosed_DemskyService.DTOs;

public class SirenaDto:Service
{
    public SirenaDto()
    {
        ServiceType = "sirena";
        ServiceListCreator._servicesList.Add(this);
    }
     
}