// public static void Main(string[] args)
// {
// {
//     var paymentProcesor = new PaymentProcessor();
//     paymentProcesor.ProcessPayment(PaymentType.CreditCard, 10, "MASTERCARD FINAL 1234");

// }

public sealed class PaymentProcessor
{
    private Dictionary<PaymentType, IPaymentStrategy> _paymentStrategies;
    public PaymentProcessor() 
    {
        Dictionary<PaymentType, IPaymentStrategy> _paymentStrategies = new Dictionary<PaymentType, IPaymentStrategy>
        {
            {
                PaymentType.CreditCard, new CreditCardPayment()
            },
            {
                PaymentType.PayPal, new PayPalPayment()
            },
            {
                PaymentType.Crypto, new CryptoPayment()
            },
            {
                PaymentType.Money, new MoneyPayment()
            },
        }

        public void ProcessPayment(PaymentType paymentType, decimal amount, string identifier) 
        {
            if (paymentType == PaymentType.CreditCard)
            {
                Console.WriteLine("Credit Card payment are not supported.");    
                return;
            }

            if (_paymentStrategies.TryGetValue(paymentType, out var strategy))
            {
                strategy.ProcessPayment(amount, identifier);
            }
            else 
            {
                Console.WriteLine($"Unsuported payment type");
            }
        }
    }
}

public interface IPaymentStrategy 
{
    void ProcessPayment(decimal amount, string identifier);
}

public class CreditCardPayment : IPaymentStrategy 
{
    public void ProcessPayment(decimal amount, string identifier) 
    {
        Console.WriteLine($"Processing credit card amout {amount} identifier {identifier}");
    }
}

public class PayPalPayment : IPaymentStrategy 
{
    public void ProcessPayment(decimal amount, string identifier) 
    {
        Console.WriteLine($"Processing credit card amout {amount} identifier {identifier}");
    }
}

public class CryptoPayment : IPaymentStrategy 
{
    public void ProcessPayment(decimal amount, string identifier) 
    {
        Console.WriteLine($"Processing credit card amout {amount} identifier {identifier}");
    }
}

public class MoneyPayment : IPaymentStrategy 
{
    public void ProcessPayment(decimal amount, string identifier) 
    {
        Console.WriteLine($"Processing credit card amout {amount} identifier {identifier}");
    }
}

public enum PaymentType
{
    CreditCard = 0,
    PayPal = 1,
    Crypto = 2,
    Money = 3,
    DebitCard = 4
}

