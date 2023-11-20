using Builder.Properties;

namespace Builder;

public class SmartPhoneBuilder
{
    private SmartPhone _phone = new SmartPhone();

    public SmartPhone Build()
    {
        var result = _phone;
        _phone = new SmartPhone();
        return result;
    }

    public SmartPhoneBuilder SetCamera(Camera camera)
    {
        _phone.Camera = camera;
        return this;
    }
    
    public SmartPhoneBuilder SetProcessor(Processor processor)
    {
        _phone.Processor = processor;
        return this;
    }
    
    public SmartPhoneBuilder SetScreen(Screen screen)
    {
        _phone.Screen = screen;
        return this;
    }
}