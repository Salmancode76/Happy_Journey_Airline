using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Journey_Airline
{
    public class Subscription
    {
        private int subscriptionId;
        private List<TravelerObserver> subscribers;
        private List<Service> servicesSubscription;
        private DateTime startDate;
        private DateTime endDate;
        private double cost;

        public Subscription()
        {
        }

        public Subscription(int subscriptionId, List<TravelerObserver> subscribers, List<Service> servicesSubscription, DateTime startDate, DateTime endDate, double cost)
        {
            this.subscriptionId = subscriptionId;
            this.subscribers = subscribers;
            this.servicesSubscription = servicesSubscription;
            this.startDate = startDate;
            this.endDate = endDate;
            this.cost = cost;
        }

        public int SubscriptionId { get; set; }

        public List<Service> ServicesSubscription { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime StartDate { get; set; }

        public double Cost { 
            get {  return cost; }
            set
                {
                    if (cost > 0)
                    {
                        this.cost = cost;
                    } 
                }
            }

        public void attach(TravelerObserver traveler)
        {
            subscribers.Add(traveler);
        }

        public void detach(TravelerObserver traveler)
        {
            int i = subscribers.IndexOf(traveler);
            if (i >= 0)
            {
                subscribers.Remove(traveler);
            }
        }

        public void notify()
        {
            foreach (TravelerObserver observer in subscribers)
            {
                observer.update(new Service());
            }
        }

        public void addService(Service service)
        {
            servicesSubscription.Add(service);
        }
    }
}
