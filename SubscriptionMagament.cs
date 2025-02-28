using System.Data;
using System.Security.Authentication.ExtendedProtection;

namespace SubscriptionMagament
{
    public class SubscriptionManager
    {
        private List<User> Users;
        public List<Subscription> AllSubscriptions { get; private set; }
        private string ManagerName;
        private string ContactInfo;

        public SubscriptionManager(string managerName, string contactInfo)
        {
            Users = new List<User>();
            AllSubscriptions = new List<Subscription>();
            ManagerName = managerName;
            ContactInfo = contactInfo;
        }

        public void AddSubscription(User user, Subscription subscription)
        {
            user.Subscriptions.Add(subscription);
            AllSubscriptions.Add(subscription);
            Console.WriteLine($"Подписка {subscription} успешно подключена");
        }
        /*
        public void EditTask(Subscription task, string newDescription, DateTime newDueDate, string newPriority)
        {
            task.Description = newDescription;
            task.DueDate = newDueDate; 
            task.Priority = newPriority;
            Console.WriteLine($"Задача {task.TaskID} успешно изменена");
        }
        */

        public void CancelSubscription(User user, Subscription subscription)
        {
            if (user.Subscriptions.Contains(subscription))
            {
                user.Subscriptions.Remove(subscription);
                AllSubscriptions.Remove(subscription);
                Console.WriteLine($"Подписка {subscription} успешно отменена");
            }
        }

        public List<Subscription> GetActiveSubscriptions(User user)
        {
            List<Subscription> ActiveSubscrptions = new List<Subscription>();
            foreach (var subscription in user.Subscriptions)
            {
                if(subscription.EndDate >= DateTime.Now)
                {
                    ActiveSubscrptions.Add(subscription);
                }
            }
            return ActiveSubscrptions;
        }
        public List<Subscription> GetExpiredSubscriptions(User user)
        {
            List<Subscription> ExpiredSubscrptions = new List<Subscription>();
            foreach (var subscription in user.Subscriptions)
            {
                if (subscription.EndDate >= DateTime.Now)
                {
                    ExpiredSubscrptions.Add(subscription);
                }
            }
            return ExpiredSubscrptions;
        }

        public string GetSubscriptionDetails(Subscription subscription)
        {
            return $"Название: {subscription.ServiceName} (ID: {subscription.SubscriptionID}), Дата начала: {subscription.StartDate}, Дата окончания: {subscription.EndDate}, Цена: {subscription.Price}";
        }
    }
}

namespace SubscriptionMagament
{
    public class Subscription
    {
        public string SubscriptionID { get; private set; }
        public string ServiceName { get; private set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; private set; }

        public Subscription(string subscriptionID, string serviceName, DateTime startDate, DateTime endDate, double price) 
        {
            SubscriptionID = subscriptionID;
            ServiceName = serviceName;
            StartDate = startDate;
            EndDate = endDate;
            Price = price;
        }
    }
}

namespace SubscriptionMagament
{
    public class User
    {
        public string UserID { get; private set; }
        public string Name { get; private set; }
        private string Email;
        public List<Subscription> Subscriptions { get; private set; }

        public User(string userID,  string name, string email)
        {
            UserID = userID;
            Name = name;
            Email = email;
            Subscriptions = new List<Subscription>();
        }
    }
}

