using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Security.Authentication.ExtendedProtection;

namespace Lab2
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
        }

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
                if (subscription.EndDate >= DateTime.Now)
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
    }
}