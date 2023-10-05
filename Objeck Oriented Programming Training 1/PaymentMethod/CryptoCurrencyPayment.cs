using System.Xml;
using Objeck_Oriented_Programming_Training_1.Interfaces;

namespace Objeck_Oriented_Programming_Training_1.PaymentMethod;

public class CryptoCurrencyPayment : IPaymentMethod, ITwoFactorAuthenthication, iInstallmentPayment
{
    public void SendCodes(int codes, User targetUser)
    {
        
    }

    public void VadilateCodes(int codes, User targetUser)
    {
        
    }

    public int CalculateInstallment(int price, int totalMonth)
    {
        return price / totalMonth;
    }

    public void PromptInstallment(User user)
    {
        
    }

    public void Authorize(User user)
    {
        Console.WriteLine("Crypto Currency Authorized");
    }

    public void Transact(string productId)
    {
        Console.WriteLine("Crypto Transaction Success");
    }
}