using System;
using System.Collections.Generic;
using System.Text;

namespace STOCK_PEREZ.Models
{
    public class DeliveryModel
    {
       
            public long reference { get; set; }
            public string Date { get; set; }
            public string PlaceOfDelivery { get; set; }

            public UserModel User { get; set; }

            public DeliveryModel()
            {

            }

            public DeliveryModel (long reference, string date, string placeOfDelivery, UserModel user)
            {
                this.reference = reference;
                Date = date;
                PlaceOfDelivery = placeOfDelivery;
                User = user;
            }
        }

    
}
