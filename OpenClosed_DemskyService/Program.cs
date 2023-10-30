// See https://aka.ms/new-console-template for more information

using OpenClosed_DemskyService;
using OpenClosed_DemskyService.DTOs;
using OpenClosed_DemskyService.Interfaces;
using OpenClosed_DemskyService.Services;

var list = ServiceListCreator._servicesList;

ServiceCreator serviceCreator = new ServiceCreator();

var service = serviceCreator.CreateService(ServiceListCreator._servicesList, new ServiceChoose("myAgent"));

Console.WriteLine(service.ServiceType);