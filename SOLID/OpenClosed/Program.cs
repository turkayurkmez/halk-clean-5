// See https://aka.ms/new-console-template for more information
using OpenClosed;

Console.WriteLine("Hello, World!");
/*
 * Bir nesne gelişime AÇIK değişime KAPALI olmalıdır.
 * 
 */
Customer customer = new Customer() { Name = "Türkay", CardType = new PremiumCard() };
OrderManager orderManager = new OrderManager { Customer = customer };
Console.WriteLine(orderManager.GetDiscountedPrice(100));