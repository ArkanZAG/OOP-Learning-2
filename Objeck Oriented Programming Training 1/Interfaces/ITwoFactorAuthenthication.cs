namespace Objeck_Oriented_Programming_Training_1.Interfaces;

public interface ITwoFactorAuthenthication
{
    public void SendCodes(int codes, User targetUser);
    public void VadilateCodes(int codes, User targetUser);
}