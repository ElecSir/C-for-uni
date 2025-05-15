using System;

namespace Lab2
{
    public class Subscription
    {
        public string SubscriptionID { get; private set; }
        public string ServiceName { get; private set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; private set; }
        public User User { get; set; }

        public Subscription(string subscriptionID, string serviceName, DateTime startDate, DateTime endDate, double price, User user)
        {
            SubscriptionID = subscriptionID;
            ServiceName = serviceName;
            StartDate = startDate;
            EndDate = endDate;
            Price = price;
            User = user;
        }

        public override string ToString() => ServiceName;

        public string GetSubscriptionDetails()
        {
            return $"Название: {ServiceName} (ID: {SubscriptionID}), Дата начала: {StartDate}, Дата окончания: {EndDate}, Цена: {Price}, Пользователь: {User}";
        }
    }
}
