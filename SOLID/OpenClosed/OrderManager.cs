namespace OpenClosed
{
    //public enum CardTypes
    //{
    //    Standard,
    //    Silver,
    //    Gold,
    //    Premium
    //}

    public abstract class CardTypes
    {
        public abstract double GetDiscountedPrice(double price);


    }

    public class StandardCard : CardTypes
    {
        public override double GetDiscountedPrice(double price)
        {
            return price * .95;
        }
    }
    public class SilverCard : CardTypes
    {
        public override double GetDiscountedPrice(double price)
        {
            return price * .90;
        }
    }

    public class GoldCard : CardTypes
    {
        public override double GetDiscountedPrice(double price)
        {
            return price * .85;
        }
    }
    public class PremiumCard : CardTypes
    {
        public override double GetDiscountedPrice(double price)
        {
            return price * .80;
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public CardTypes CardType { get; set; }
    }


    public class OrderManager
    {
        public Customer Customer { get; set; }
        public double GetDiscountedPrice(double price)
        {
            //switch (Customer.CardType)
            //{
            //    case CardTypes.Standard:
            //        return price * .95;
            //    case CardTypes.Silver:
            //        return price * .90;

            //    case CardTypes.Gold:
            //        return price * .85;
            //    case CardTypes.Premium:

            //    default:
            //        return price;

            //}

            return Customer.CardType.GetDiscountedPrice(price);
        }
    }
}
