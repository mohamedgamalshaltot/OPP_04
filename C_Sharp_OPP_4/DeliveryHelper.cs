using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OPP_4
{
    internal static class DeliveryHelper
    {
       internal static void PrintShipmentDetails(Shipment shipment)
        {
            if (shipment !=null)
            {
                shipment.PrintShipment();
            }
        }
    }
}
