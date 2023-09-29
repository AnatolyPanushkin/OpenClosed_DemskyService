using OpenClosed_DemskyService.Interfaces;
using OpenClosed_DemskyService.Services;

namespace OpenClosed_DemskyService.DTOs;

public class MyAgentDto:Service
{
   static MyAgentDto()
   {
      ServiceListCreator._servicesList.Add(new MyAgentDto());
   }
   public MyAgentDto()
   {
      ServiceType = "myAgent";
   }
}