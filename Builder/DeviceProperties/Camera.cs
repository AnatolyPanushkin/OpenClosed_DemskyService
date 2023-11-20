namespace Builder.Properties;

public class Camera
{
    public Camera(string res, string NumberOfLenses, string Type)
    {
        this.Resolution = res;
        this.NumberOfLenses = NumberOfLenses;
        this.Type = Type;
    }
    
    public string Resolution { get; set; }
    
    public string NumberOfLenses { get; set; }
    
    public string Type { get; set; }
}