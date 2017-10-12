﻿﻿using Newtonsoft.Json;

namespace Stripe
{
    public class StripeInvoiceListOptions : StripeListOptions
    {
        /// <summary>
        /// The billing mode of the invoice to retrieve. One of <see cref="StripeBilling" />.
        /// </summary>
        [JsonProperty("billing")]
        public string Billing { get; set; }

        [JsonProperty("customer")]
        public string CustomerId { get; set; }
 
        [JsonProperty("date")]
        public StripeDateFilter Date { get; set; }

        /// <summary>
        /// A filter on the list based on the object due_date field.
        /// </summary>
        [JsonProperty("due_date")]
        public StripeDateFilter DueDate { get; set; }

        [JsonProperty("subscription")]
        public string SubscriptionId { get; set; }
    }
}
