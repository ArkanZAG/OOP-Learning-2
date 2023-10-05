namespace Objeck_Oriented_Programming_Training_1.Interfaces;

public interface ILoyaltyPoints
{
    public void AddPoints(int points, User targetUser);
    public void UsePoints(int points, User targetUser);
}