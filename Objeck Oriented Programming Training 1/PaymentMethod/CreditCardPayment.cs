using Objeck_Oriented_Programming_Training_1.Interfaces;

namespace Objeck_Oriented_Programming_Training_1.PaymentMethod;

public class CreditCardPayment : IPaymentMethod, ITwoFactorAuthenthication
{
    public void SendCodes(int codes, User targetUser)
    {
        
    }

    public void VadilateCodes(int codes, User targetUser)
    {
        
    }

    public void Authorize(User user)
    {
        Console.WriteLine("Credit Card Authorized");
    }

    public void Transact(string productId)
    {
        Console.WriteLine("Credit Card Transaction Success");
    }
}