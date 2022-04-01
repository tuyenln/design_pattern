using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start getting tickets!");

            var random = new Random();

            for(var i = 0; i < 5; i++)
            {
                var ticket = new Ticket();
                ticket.SetName("Ticket " + (i + 1));
                ticket.SetPrice(50d * i);
                GeneratePromoteStrategy(random, ticket);
                LogTicketDetails(ticket);

                GeneratePromoteStrategy(random, ticket);
                LogTicketDetails(ticket);
            }
        }

        private static void LogTicketDetails(Ticket ticket)
        {
            Console.WriteLine(
                                "Promoted price of " +
                                ticket.GetName() +
                                " is " +
                                ticket.GetPromtedPrice() + " " +
                                ticket.GetPromoteStrategy().GetType().Name + "\n"
                                );
        }

        private static void GeneratePromoteStrategy(Random random, Ticket ticket)
        {
            var strategyIndex = random.Next(0, 2);

            switch (strategyIndex)
            {
                case 0:
                    ticket.SetPromoStrategy(new NoDiscountStrategy());
                    break;
                case 1:
                    ticket.SetPromoStrategy(new QuarterDiscountStrategy());
                    break;
                default:
                    ticket.SetPromoStrategy(new HalfDiscountStrategy());
                    break;
            }
        }
    }
}
