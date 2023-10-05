using Objeck_Oriented_Programming_Training_1.Interfaces;

namespace Objeck_Oriented_Programming_Training_1.PaymentMethod;

public class BankTransferPayment : IPaymentMethod, ITwoFactorAuthenthication, ILoyaltyPoints
{
    public void SendCodes(int codes, User targetUser)
    {
        
    }

    public void VadilateCodes(int codes, User targetUser)
    {
        
    }

    public void AddPoints(int points, User targetUser)
    {
        
    }

    public void UsePoints(int points, User targetUser)
    {
        
    }

    public void Authorize(User user)
    {
        Console.WriteLine("Bank Authorized");
    }

    public void Transact(string productId)
    {
        Console.WriteLine("Bank Transaction Success");
    }
}