namespace Objeck_Oriented_Programming_Training_1.Interfaces;

public interface iInstallmentPayment
{
    public int CalculateInstallment(int price, int totalMonth);
    public void PromptInstallment(User user);
}