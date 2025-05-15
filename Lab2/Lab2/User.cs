using System.Collections.Generic;

namespace Lab2
{
    public class User
    {
        public string UserID { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public List<Subscription> Subscriptions { get; private set; }

        public User(string userID, string name, string email)
        {
            UserID = userID;
            Name = name;
            Email = email;
            Subscriptions = new List<Subscription>();
        }

        public override string ToString() => Name;

        public string GetUserDetails()
        {
            return $"Имя: {Name} (ID: {UserID}), Электронная почта: {Email}";
        }
    }
}
