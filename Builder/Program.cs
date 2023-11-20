// See https://aka.ms/new-console-template for more information

using Builder;
using Builder.Properties;

var camera = new Camera("48Mp","3", "Front");
var processor = new Processor(5000,8, 4, 8);
var screen = new Screen(32, "wildHD", "400Lm", 120);

var phone = new SmartPhoneBuilder().SetCamera(camera).Build();

Console.WriteLine(phone.Camera.Type);

var phone2 = new SmartPhoneBuilder().SetProcessor(processor).SetCamera(camera).SetScreen(screen).Build();

Console.WriteLine(phone2.Processor.Frequency);
