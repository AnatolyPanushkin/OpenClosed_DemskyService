namespace dependencyInversion_Correct;

public class OrderCreator
{
    private readonly ILogger _logger;

    public OrderCreator(ILogger logger)
    {
        _logger = logger;
    }

    public Order CreateOrder()
    {
        _logger.Log("logger: order create");
        Console.WriteLine("OrderCreator: order create");
        return new Order();
    }
}