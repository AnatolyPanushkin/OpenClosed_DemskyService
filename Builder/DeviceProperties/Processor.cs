namespace Builder.Properties;

public class Processor
{
    public Processor(int Frequency, int NumberOfCores, int CacheL1, int acheL2)
    {
        this.Frequency = Frequency;
        this.NumberOfCores = NumberOfCores;
        this.CacheL1 = CacheL1;
        this.CacheL2 = CacheL2;
    }
    public int Frequency { get; set; }
    
    public int NumberOfCores { get; set; }
    
    public int CacheL1 { get; set; }
    
    public int CacheL2 { get; set; }
}