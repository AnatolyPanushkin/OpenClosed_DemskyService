namespace Builder.Properties;

public class Screen
{
    public Screen(double Diagonal, string Resolution, string Brightness, int Frequency)
    {
        this.diagonal = Diagonal;
        this.resolution = Resolution;
        this.brightness = Brightness;
        this.frequency = Frequency;
    }
    public double diagonal { get; set; }
    public string resolution { get; set; }
    public string brightness { get; set; }
    public int frequency { get; set; }
}