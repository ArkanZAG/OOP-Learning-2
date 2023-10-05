using Objeck_Oriented_Programming_Training_1;
using Objeck_Oriented_Programming_Training_1.PaymentMethod;

PaymentSystem system = new PaymentSystem();
User user1 = new User();
system.Authorize(user1, new CreditCardPayment());
system.Authorize(user1, new DigitalWalletPayment());