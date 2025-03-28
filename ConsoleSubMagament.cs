using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;

namespace SubscriptionManagement
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
            }
        }

        public void GetActiveSubscriptions(User user)
        {
            List<Subscription> ActiveSubscrptions = new List<Subscription>();
            foreach (var subscription in user.Subscriptions)
            {
                if (subscription.EndDate >= DateTime.Now)
                {
                    ActiveSubscrptions.Add(subscription);
                    Console.WriteLine(subscription);
                }
            }
            
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

        public void GetSubscriptionDetails(Subscription subscription)
        {
            Console.WriteLine($"Название: {subscription.ServiceName} (ID: {subscription.SubscriptionID}), Дата начала: {subscription.StartDate}, Дата окончания: {subscription.EndDate}, Цена: {subscription.Price}");
        }
    }

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

    public class User
    {
        public string UserID { get; private set; }
        public string Name { get; private set; }
        private string Email;
        public List<Subscription> Subscriptions { get; private set; }

        public User(string userID, string name, string email)
        {
            UserID = userID;
            Name = name;
            Email = email;
            Subscriptions = new List<Subscription>();
        }
    }

    class Program
    {
        static SubscriptionManager manager = new SubscriptionManager("Petr Ivanov", "petr.ivanov@example.com");
        static List<User> users = new List<User>();
        static List<Subscription> allSubscriptions = new List<Subscription>();
        static void Main(string[] args)
        {
            bool exit = false;
            while (exit != true)
            {
                Console.WriteLine("=== Система управления подписками ===");
                Console.WriteLine("1. Создать пользователя");
                Console.WriteLine("2. Создать подписку");
                Console.WriteLine("3. Добавить подписку пользователю");
                Console.WriteLine("4. Отменить подписку");
                Console.WriteLine("5. Показать активные подписки пользователя");
                Console.WriteLine("6. Показать истекшие подписки пользователя");
                Console.WriteLine("7. Показать информацию о подписке");
                Console.WriteLine("8. Выйти из программы");
                Console.WriteLine("Выберите действие:");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CreateUser();
                        break;
                    case "2":
                        CreateSubscription();
                        break;
                    case "3":
                        AddSubscriptionToUser();
                        break;
                    case "4":
                        CancelSubscription();
                        break;
                    case "5":
                        ShowActiveSubscriptions();
                        break;
                    case "6":
                        ShowExpiredSubscriptions();
                        break;
                    /*case "7":
                        GetDetailsAboutSubscription();
                        break;*/
                    case "8":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Выберите вариант из списка");
                        break;
                }

                static void CreateUser()
                {
                    Console.Write("Введите ID пользователя: ");
                    var id = Console.ReadLine();
                    Console.Write("Введите имя пользователя: ");
                    var name = Console.ReadLine();
                    Console.Write("Введите email пользователя: ");
                    var email = Console.ReadLine();

                    var user = new User(id, name, email);
                    users.Add(user);
                    Console.WriteLine("Пользователь успешно создан!");
                }

                static void CreateSubscription()
                {
                    Console.Write("Введите ID подписки: ");
                    var id = Console.ReadLine();
                    Console.Write("Введите название пдписки: ");
                    var name = Console.ReadLine();
                    Console.Write("Введите дату начала (гггг-мм-дд): ");
                    var startDate = DateTime.Parse(Console.ReadLine());
                    Console.Write("Введите дату окончания (гггг-мм-дд): ");
                    var endDate = DateTime.Parse(Console.ReadLine());
                    Console.Write("Введите цену подписки: ");
                    double price = double.Parse(Console.ReadLine());

                    var subscription = new Subscription(id, name, startDate, endDate, price);
                    allSubscriptions.Add(subscription);
                    Console.WriteLine("Подписка успешно создана!");
                }

                static void AddSubscriptionToUser()
                {
                    Console.Write("Выберите номер пользователя: ");
                    int userIndex = int.Parse(Console.ReadLine());

                    Console.Write("Выберите номер подписки: ");
                    int subIndex = int.Parse(Console.ReadLine());

                    manager.AddSubscription(users[userIndex], allSubscriptions[subIndex]);
                    Console.WriteLine("Подписка успешно добавлена пользователю!");
                }

                static void CancelSubscription()
                {
                    Console.Write("Выберите номер пользователя: ");
                    int userIndex = int.Parse(Console.ReadLine());

                    var user = users[userIndex];
                    if (user.Subscriptions.Count == 0)
                    {
                        Console.WriteLine("У пользователя нет подписок!");
                        return;
                    }

                    Console.WriteLine("Подписки пользователя:");
                    for (int i = 0; i < user.Subscriptions.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {user.Subscriptions[i].ServiceName}");
                    }

                    Console.Write("Выберите номер подписки для отмены: ");
                    int subIndex = int.Parse(Console.ReadLine());

                    manager.CancelSubscription(user, user.Subscriptions[subIndex]);
                    Console.WriteLine("Подписка успешно отменена!");
                }

                static void ShowActiveSubscriptions()
                {
                    Console.Write("Выберите номер пользователя: ");
                    int userIndex = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nАктивные подписки:");
                    manager.GetActiveSubscriptions(users[userIndex]);
                }

                static void ShowExpiredSubscriptions()
                {
                    Console.Write("Выберите номер пользователя: ");
                    int userIndex = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nИстекшие подписки:");
                    manager.GetExpiredSubscriptions(users[userIndex]);
                }
            }
            
        }
    }
}
