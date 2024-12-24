using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Journey_Airline
{
    public class Service
    {
        private int serviceId;
        private string serviceName;
        private string description;
        public double price;




        public Service()
        {
        }
        public Service(string serviceName, string description, double price)
        {
            ServiceName = serviceName;
            Description = description;
            Price = price;
        }
        public Service(int serviceId, string serviceName, string description, double price)
        {
            ServiceId = serviceId;
            ServiceName = serviceName;
            Description = description;
            Price = price;
        }

        public int ServiceId { get; set; }

        public string ServiceName { get; set; }

        public string Description { get; set; }

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative.");
                price = value;
            }
        }
        public override string ToString()
        {
            return ServiceName;
        }




    }
}
