namespace Objeck_Oriented_Programming_Training_1.Interfaces;

public interface IPaymentMethod
{
    public void Authorize(User user);
    public void Transact(string productId);
}