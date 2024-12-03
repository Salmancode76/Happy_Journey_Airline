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
        private double price;

        public Service()
        {
        }

        public Service(string serviceName, string description, double price)
        {
            this.serviceId = serviceId++;
            this.serviceName = serviceName;
            this.description = description;
            this.price = price;
        }

        public int ServiceId { get; set; }

        public string ServiceName { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

    }
}
