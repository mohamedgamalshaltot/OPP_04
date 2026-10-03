using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OPP_4
{
   internal  abstract class Shipment
    {
      public string trackingCode { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
        public decimal DeliveryFee { get; set; }

        public DeliveryAddress destination { get; set; }
        //Abstract Members
        public abstract decimal EstimatedCost { get; }
        public abstract void PrintShipment();

        public Shipment(string trackingCode)
        {
            if (string.IsNullOrWhiteSpace(trackingCode))
                throw new ArgumentException("Tracking code cannot be null or empty.");
            this.trackingCode = trackingCode;

            this.Description = "";
            this.Weight = 0;
          
            this.destination = new DeliveryAddress();

            SetDescription("Unknown");
            SetWeight(1);
           this.deliveryFee = 50;
        }

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            if (string.IsNullOrWhiteSpace(trackingCode))
            {
                throw new ArgumentException("Tracking code cannot be null or empty.", nameof(trackingCode));
            }
            this.trackingCode = trackingCode;
            this.Description = "";
            this.Weight = 0;
           
            this.destination = destination;

            SetDescription(description);
            SetWeight(weight);
           
        }
        public string GetTrackingCode()
        {
            return trackingCode;
        }
        public string GetDescription()
        {
            return Description;
        }
        public void SetDescription(string Value)
        {
            if (!string.IsNullOrWhiteSpace(Value))
                Description = Value;
        }
        public decimal GetWeight()
        {
            return Weight;
        }
        public void SetWeight(decimal value)
        {
            if (value >= 0)
            {
                Weight = value;
            }
        }
       
        public DeliveryAddress GetDestination()
        {
            return destination;
        }
        public void SetDestination(DeliveryAddress value)
        {
            destination = value;
        }
        public virtual decimal deliveryFee { get; set; }
       
                public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;
        }

       
        
        // Method Overloading: Version 1
        public void UpdateWeight(decimal newWeight)
        {
            this.Weight = newWeight;
        }

        // Method Overloading: Version 2 (Adding extra packing weight)
        public void UpdateWeight(decimal baseWeight, decimal extraPackingWeight)
        {
            this.Weight = baseWeight + extraPackingWeight;
        }
    }
}

