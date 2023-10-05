using Objeck_Oriented_Programming_Training_1.Interfaces;

namespace Objeck_Oriented_Programming_Training_1;

public class PaymentSystem
{
    public void Authorize(User user, IPaymentMethod paymentMethod)
    {
        paymentMethod.Authorize(user);
    }

    public void Transact(string productId, IPaymentMethod paymentMethod)
    {
        
    }
}