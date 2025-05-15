using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class AppContext
    {
        public static IList<Subscription> Subscriptions { get; } = new List<Subscription>();
        public static IList<User> Users { get; } = new List<User>();
    }
}
